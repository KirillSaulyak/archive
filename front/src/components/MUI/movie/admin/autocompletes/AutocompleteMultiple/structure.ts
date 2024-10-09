import { GeneralProps } from "../structure";

export interface Props extends GeneralProps {
  oldValueIds: string[] | undefined;
  onChange: (value: string[]) => void;
}
