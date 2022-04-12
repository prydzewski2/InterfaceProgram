export const enum TelemetryType {
  Reading = 'V',
  Configuration = 'T'
}

export interface Telemetry {
  type: TelemetryType,
  index: number,
  value?: string,
  valueType: TelemetryValueType
}

class TelemetryValue implements Telemetry {
  constructor(
    public valueType: TelemetryValueType,
    public index: number,
    public type: TelemetryType = TelemetryType.Configuration
  ) { }
}

export enum TelemetryValueType {
  Rpm = 'RPM',
  Sensor = 'Sensor',
  MajorVersion = 'Major Version',
  MinorVersion = 'Minor Version',
  QsType = 'QS Type',
  Ds = 'DS',
  QsEnable = 'QS Enable',
  DsEnable = 'DS Enable',
  PushCheckQs = 'Push Check QS',
  Pulses = 'Pulses',
  PreDelayQS = 'PreDelayQS',
  CutTime1 = 'CutTime1',
  CutTime2 = 'CutTime2',
  CutTime3 = 'CutTime3',
  CutTime4 = 'CutTime4',
  CutTime5 = 'CutTime5',
  CutTime6 = 'CutTime6',
  CutTime7 = 'CutTime7',
  CutTime8 = 'CutTime8',
  QSForce = 'QSForce',
  MinRPMQS = 'MinRPMQS',
  PreDelayDS = 'PreDelayDS',
  BlipTime1 = 'BlipTime1',
  BlipTime2 = 'BlipTime2',
  BlipTime3 = 'BlipTime3',
  BlipTime4 = 'BlipTime4',
  BlipTime5 = 'BlipTime5',
  BlipTime6 = 'BlipTime6',
  BlipTime7 = 'BlipTime7',
  BlipTime8 = 'BlipTime8',
  DSForce = 'DSForce',
  MinRPMDS = 'MinRPMDS',
  MaxRPMDS = 'MaxRPMDS',
  PostDelayQS = 'PostDelayQS',
  PostDelayDS = 'PostDelayDS'
}

export type Telemetries = Map<TelemetryValueType, Telemetry>;

export const TelemetryValues: Telemetries = new Map([
  [TelemetryValueType.Rpm, new TelemetryValue(TelemetryValueType.Rpm, 1, TelemetryType.Reading)],
  [TelemetryValueType.Sensor, new TelemetryValue(TelemetryValueType.Sensor, 2, TelemetryType.Reading)],
  [TelemetryValueType.MajorVersion, new TelemetryValue(TelemetryValueType.MajorVersion, 1)],
  [TelemetryValueType.MinorVersion, new TelemetryValue(TelemetryValueType.MinorVersion, 2)],
  [TelemetryValueType.QsType, new TelemetryValue(TelemetryValueType.QsType, 3)],
  [TelemetryValueType.Ds, new TelemetryValue(TelemetryValueType.Ds, 4)],
  [TelemetryValueType.QsEnable, new TelemetryValue(TelemetryValueType.QsEnable, 5)],
  [TelemetryValueType.DsEnable, new TelemetryValue(TelemetryValueType.DsEnable, 6)],
  [TelemetryValueType.PushCheckQs, new TelemetryValue(TelemetryValueType.PushCheckQs, 7)],
  [TelemetryValueType.Pulses, new TelemetryValue(TelemetryValueType.Pulses, 8)],
  [TelemetryValueType.PreDelayQS, new TelemetryValue(TelemetryValueType.PreDelayQS, 9)],
  [TelemetryValueType.CutTime1, new TelemetryValue(TelemetryValueType.CutTime1, 10)],
  [TelemetryValueType.CutTime2, new TelemetryValue(TelemetryValueType.CutTime2, 11)],
  [TelemetryValueType.CutTime3, new TelemetryValue(TelemetryValueType.CutTime3, 12)],
  [TelemetryValueType.CutTime4, new TelemetryValue(TelemetryValueType.CutTime4, 13)],
  [TelemetryValueType.CutTime5, new TelemetryValue(TelemetryValueType.CutTime5, 14)],
  [TelemetryValueType.CutTime6, new TelemetryValue(TelemetryValueType.CutTime6, 15)],
  [TelemetryValueType.CutTime7, new TelemetryValue(TelemetryValueType.CutTime7, 16)],
  [TelemetryValueType.CutTime8, new TelemetryValue(TelemetryValueType.CutTime8, 17)],
  [TelemetryValueType.QSForce, new TelemetryValue(TelemetryValueType.QSForce, 18)],
  [TelemetryValueType.MinRPMQS, new TelemetryValue(TelemetryValueType.MinRPMQS, 19)],
  [TelemetryValueType.PreDelayDS, new TelemetryValue(TelemetryValueType.PreDelayDS, 20)],
  [TelemetryValueType.BlipTime1, new TelemetryValue(TelemetryValueType.BlipTime1, 21)],
  [TelemetryValueType.BlipTime2, new TelemetryValue(TelemetryValueType.BlipTime2, 22)],
  [TelemetryValueType.BlipTime3, new TelemetryValue(TelemetryValueType.BlipTime3, 23)],
  [TelemetryValueType.BlipTime4, new TelemetryValue(TelemetryValueType.BlipTime4, 24)],
  [TelemetryValueType.BlipTime5, new TelemetryValue(TelemetryValueType.BlipTime5, 25)],
  [TelemetryValueType.BlipTime6, new TelemetryValue(TelemetryValueType.BlipTime6, 26)],
  [TelemetryValueType.BlipTime7, new TelemetryValue(TelemetryValueType.BlipTime7, 27)],
  [TelemetryValueType.BlipTime8, new TelemetryValue(TelemetryValueType.BlipTime8, 28)],
  [TelemetryValueType.DSForce, new TelemetryValue(TelemetryValueType.DSForce, 29)],
  [TelemetryValueType.MinRPMDS, new TelemetryValue(TelemetryValueType.MinRPMDS, 30)],
  [TelemetryValueType.MaxRPMDS, new TelemetryValue(TelemetryValueType.MaxRPMDS, 31)],
  [TelemetryValueType.PostDelayQS, new TelemetryValue(TelemetryValueType.PostDelayQS, 32)],
  [TelemetryValueType.PostDelayDS, new TelemetryValue(TelemetryValueType.PostDelayDS, 33)],
]);
