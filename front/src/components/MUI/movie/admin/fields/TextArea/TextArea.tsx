import TextField from "@mui/material/TextField";

import { GeneralProps } from "../structure";

import { useEffect, useState } from "react";

const TextArea = ({ autoFocus = false, label, oldValue, onChange }: GeneralProps) => {
  const [value, setValue] = useState("");

  useEffect(() => {
    setValue(oldValue);
  }, [oldValue]);

  const onChangeHandler = (value: string) => {
    setValue(value);
    onChange(value);
  };

  return (
    <TextField
      autoFocus={autoFocus}
      label={label}
      sx={{ width: 700 }}
      value={value}
      onChange={(event) => onChangeHandler(event.target.value)}
      multiline
    />
  );
};

export default TextArea;
