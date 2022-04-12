export const enum TelemetryType {
  Reading = 'V',
  Configuration = 'T'
}

export enum TelemetryValueType {
  Rpm = 'RPM',
  Sensor = 'Sensor',
  MajorVersion = 'Major Version',
  MinorVersion = 'Minor Version',

}

export interface Telemetry {
  type: TelemetryType,
  index: number,
  value?: string,
  valueType: TelemetryValueType
}

export type Telemetries = Map<TelemetryValueType, Telemetry>;

export const TelemetryValues: Telemetries = new Map([
  [TelemetryValueType.Rpm, {type: TelemetryType.Reading, valueType: TelemetryValueType.Rpm, index: 1}],
  [TelemetryValueType.Sensor, {type: TelemetryType.Reading, valueType: TelemetryValueType.Sensor, index: 2}],
  [TelemetryValueType.MajorVersion, {type: TelemetryType.Configuration, valueType: TelemetryValueType.MajorVersion, index: 1}],
  [TelemetryValueType.MinorVersion, {type: TelemetryType.Configuration, valueType: TelemetryValueType.MinorVersion, index: 2}]
]);
