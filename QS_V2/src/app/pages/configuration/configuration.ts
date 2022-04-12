import { Component, ChangeDetectorRef } from '@angular/core';
import { FormBuilder, Validators, FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { ViewWillEnter } from '@ionic/angular';
import {Telemetries, TelemetryComponents, TelemetryValueType } from 'src/core/models/telemetry';
import { AlertService } from 'src/core/services/common/alert-service';
import { DeviceService } from 'src/core/services/communications/device.service';
import { SerialPortService } from 'src/core/services/communications/serial-port.service';
import {Device} from "../../../core/models/device";
import {LogService} from "../../../core/services/common/log.service";

@Component({
  selector: 'app-configuration',
  templateUrl: 'configuration.html',
  styleUrls: ['configuration.scss'],
  providers: [DeviceService]
})
export class ConfigurationPage implements ViewWillEnter {
  public types = TelemetryValueType;
  public values: Telemetries = new Map([]);
  public editor = [];

  constructor(
    private changeDetectorRef: ChangeDetectorRef,
    private readonly serialPortService: SerialPortService,
    public loggerService: LogService,
    private router: Router,
    public deviceService: DeviceService,
    private readonly alertService: AlertService){}

  public async ionViewWillEnter(): Promise<void> {
    if (!this.device?.isConnected) {
      await this.router.navigate(['/']);
    } else {
      this.values = new Map([...this.device.telemetry]);
      this.deviceService.onChange().subscribe((t) => {
        this.values = new Map([...t]);
        this.changeDetectorRef.detectChanges();
      });

      this.initEditor();
    }
  }

  public getValue(key: TelemetryValueType): string {
    return this.values.get(key)?.getValue();
  }

  public get device(): Device | undefined {
    return this.deviceService.connectedDevice();
  }

  public async read() {
    await this.serialPortService.write('R');
  }

  public async blipTest() {
    await this.serialPortService.write('B');
  }

  public async cutTest() {
    await this.serialPortService.write('C');
  }

  public async reset() {
    await this.serialPortService.write('W');
  }

  public async save() {
    // await this.serialPortService.write('S,');
  }

  private initEditor(): void {
    const rows = Math.max(...Array.from(TelemetryComponents.values()).map(i => i.row));
    this.editor = new Array(rows + 1);
    Array.from(TelemetryComponents.entries()).forEach(i => {
      const value = i[1];
      const column = { telemetry: i[0], ...value };

      if (!this.editor[value.row]) {
        this.editor[value.row] = { row: value.row, columns: [] };
      }

      this.editor[value.row].columns.push(column);
    });
  }
}
