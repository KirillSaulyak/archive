import TextField from "@mui/material/TextField";

import { GeneralProps } from "../structure";

const TextFieldDialog = ({ autoFocus = false, label, onChange }: Omit<GeneralProps, "oldValue">) => {
  return (
    <TextField
      autoFocus={autoFocus}
      margin="dense"
      label={label}
      onChange={(event) => onChange(event.target.value)}
      variant="standard"
    />
  );
};

export default TextFieldDialog;
