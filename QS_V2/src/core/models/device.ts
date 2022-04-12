import { Telemetries } from "./telemetry";

export interface Device {
  id: number;
  name: string;
  isConnected: boolean;
  telemetry: Telemetries;
}
