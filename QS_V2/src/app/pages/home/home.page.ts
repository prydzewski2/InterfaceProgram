import { Component } from '@angular/core';
import { FormBuilder, Validators, FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { ViewWillEnter } from '@ionic/angular';
import { AlertService } from 'src/core/services/common/alert-service';
import { SerialPortService } from 'src/core/services/communications/serial-port.service';
import {Device} from "../../../core/models/device";
import {LogService} from "../../../core/services/common/log.service";

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})
export class HomePage implements ViewWillEnter {
  public ports: Device[];
  public pending: boolean = false;
  public formGroup: FormGroup = null;

  constructor(
    private readonly formBuilder: FormBuilder,
    private readonly serialPortService: SerialPortService,
    public loggerService: LogService,
    private router: Router,
    private readonly alertService: AlertService){}

  public async ionViewWillEnter(): Promise<void> {
    this.ports = await this.serialPortService.scan();

    await this.reset(false);
  }

  public async connect(): Promise<void> {
    this.formGroup.markAllAsTouched();
    if (this.formGroup.valid) {
      this.pending = true;
      try {
        const device  = await this.serialPortService.connect(this.devicePort.value);
        await this.router.navigate(['/pages/configuration']);
      } catch (e) {
        this.loggerService.error(e);
        await this.alertService.error([`Nie udało się zarejestrować urządzenia`]);
      } finally {
        this.pending = false;
        await this.reset(false);
      }
    }
  }

  public get devicePort(): FormControl {
    return this.formGroup.controls.devicePort as FormControl;
  }

  private async reset(isInit) {
    const port = isInit ? '' : this.formGroup?.controls?.devicePort?.value;
    this.formGroup = null;
    this.formGroup = this.formBuilder.group({
      devicePort: [port, [Validators.required]]
    });
  }
}
