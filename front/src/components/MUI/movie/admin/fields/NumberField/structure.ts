import { GeneralProps } from "../structure";

export interface Props extends Omit<GeneralProps, "oldValue" | "onChange"> {
  oldValue: number | undefined;
  units: string;
  onChange: (value: number) => void;
}
