import { GeneralProps } from "../structure";

export interface Props extends GeneralProps {
  oldValueId: string | undefined;
  onChange: (value: string) => void;
}
