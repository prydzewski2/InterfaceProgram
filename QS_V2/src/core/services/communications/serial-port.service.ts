import { Injectable } from '@angular/core';
import * as SerialPort from 'serialport';
import { Subject, Observable } from 'rxjs';
import {LogService} from "../common/log.service";
import {environment} from "../../../environments/environment";
import { Device } from '../../models/device';
import { TelemetryValues } from 'src/core/models/telemetry';

@Injectable({
  providedIn: 'root'
})
export class SerialPortService {
  private serialPortManager: typeof SerialPort;
  private onDataSubject: Subject<string>;
  private serialPort: SerialPort.SerialPort;
  private devices: Device[] = [];
  private currentDevice?: Device;

  constructor(private logger: LogService) {
    this.serialPortManager = null;
    this.onDataSubject = new Subject<string>();
  }

  public async scan(): Promise<Device[]> {
    this.logger.info('SerialPortService(scan)...');
    this.configure();
    if (this.isConnected()) {
      await this.disconnect();
    }
    return await this.scanInternal();
  }

  public async connect(serialDevice: Device): Promise<Device> {
    if (this.isConnected()) {
      await this.disconnect()
    }
    return this.connectInternal(serialDevice);
  }

  public disconnect(): Promise<any> {
    this.logger.info('SerialPortService(disconnect)...');
    return new Promise((resolve, _) => {
      if (this.isConnected()) {
        this.logger.info('SerialPortService(disconnect) disconnecting...');
        if (this.devices) {
          this.devices.forEach(dev => dev.isConnected = false);
        }
        this.currentDevice.isConnected = false;
        this.logger.info('SerialPortService(disconnect) disconnecting, starting subscriber...');
        this.serialPort.on('close', () => {
          this.logger.info('SerialPortService(disconnect) disconnecting, closing - done');
          this.serialPort = null;
          resolve(this.currentDevice);
        });
        this.logger.info('SerialPortService(disconnect) disconnecting, closing');
        this.serialPort.close(_ => {
          this.logger.info('SerialPortService(disconnect) disconnect, pending');
        });
      }
    });
  }

  public isConnected(): boolean {
    return this.serialPort?.isOpen;
  }

  public isPortConnected(): boolean {
    return this.currentDevice?.isConnected;
  }

  public connectedDevice(): Device | undefined {
    return this.currentDevice;
  }

  public dataStream(): Observable<string> {
    return this.onDataSubject;
  }

  public write(cmd: any): Promise<any> {
    this.logger.info(`SerialPortService(write) cmd:${cmd}`);
    return new Promise((resolve, reject) => {
      this.serialPort.write(cmd + '\n', error => {
        if (error) {
          this.logger.error('SerialPortService(write) write: ', error);
          reject(error);
        }
      });
      this.serialPort.drain(() => {
        this.logger.info('SerialPortService(write) drain');
        resolve(null);
      });
    });
  }

  private scanInternal(): Promise<Device[]> {
    return new Promise((resolve, reject) => {
      if(this.serialPortManager){
        this.serialPortManager.list().then(
        serialDevices => {
          this.devices = [];
          let index = 0;
          serialDevices.forEach(serialDevice => {
            this.devices.push({
              id: index,
              name: serialDevice.path,
              isConnected: false,
              telemetry: new Map([...TelemetryValues])
            });

            index++;
          });
          resolve(this.devices);
        },
        error => reject(error)
      );
      }
    });
  }

  private connectInternal(serialDevice: Device): Promise<Device> {
    this.logger.info('SerialPortService(connect)...');
    return new Promise((resolve, _) => {
      const config = environment.configuration.serial;
      this.logger.info(`SerialPortService(connect) connecting... path: ${serialDevice.name} baundRate: ${config.baudRate}`);
      this.serialPort = new this.serialPortManager(serialDevice.name, { baudRate: config.baudRate, autoOpen: config.autoOpen });
      this.logger.info('SerialPortService(connect) connecting, starting subscriber...');
      this.serialPort.on('open', () => {
        this.currentDevice = serialDevice;
        this.currentDevice.isConnected = true;
        if (this.devices) {
          this.devices.find(dev => dev.name === serialDevice.name).isConnected = true;
        }
        this.logger.info('SerialPortService(connect) connecting, done');
        resolve(this.currentDevice);
      });
      this.logger.info('SerialPortService(connect) connecting, starting stream subscriber...');
      this.serialPort.pipe(new this.serialPortManager.parsers.Readline({ delimiter: '\r\n' })).on('data', data => {
        this.onDataSubject.next(data)
      });
      this.logger.info('SerialPortService(connect) connecting, open ports...');
      this.serialPort.open(_ => {
        this.logger.info('SerialPortService(connect) connecting, pending');
      });
    });
  }

  private configure() {
    if(this.serialPortManager == null){
      this.logger.info('SerialPortService(configure)');

      if (window && window['process'] && window['process'].type) {
        this.logger.info('SerialPortService(configure) binding');
        this.serialPortManager = window['require']('serialport');
        this.logger.info('SerialPortService(configure) crated', this.serialPortManager);
      }
      this.onDataSubject = new Subject<string>();
    }
  }

  private delay(ms: number) {
    return new Promise( resolve => setTimeout(resolve, ms) );
  }
}
