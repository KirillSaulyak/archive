import { TextFieldProps } from "@mui/material";

import { GeneralProps } from "../structure";

export interface Props extends Omit<GeneralProps, "oldValue" | "onChange"> {
  params: TextFieldProps;
}
