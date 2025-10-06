import TextField from "@mui/material/TextField";

import { Props } from "./structure";

const TextFieldAutocomplete = ({ autoFocus = false, label, params }: Props) => {
  return <TextField {...params} label={label} autoFocus={autoFocus} />;
};

export default TextFieldAutocomplete;
