import { Injectable } from '@angular/core';
import { ToastController } from '@ionic/angular';

@Injectable({
  providedIn: 'root'
})
export class AlertService {
  constructor(private toastController: ToastController) { }

  async error(messages: string[], durationSeconds: number = 3): Promise<void> {
    for(const message of messages){
      await this.show(message, false, durationSeconds);
    }
  }

  async success(message: string, durationSeconds: number = 3): Promise<void> {
    await this.show(message, true, durationSeconds);
  }

  private async show(message: string, success: boolean, durationSeconds: number): Promise<void> {
    const toast = await this.toastController.create({ message, position: 'top', duration: durationSeconds * 1000, color: success ? 'success' : 'danger'});
    await toast.present();
  }
}
