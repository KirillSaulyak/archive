import TextFieldMUI from "@mui/material/TextField";
import InputAdornment from "@mui/material/InputAdornment";

import { Props } from "./structure";

import { useEffect, useState } from "react";

const NumberField = ({ autoFocus = false, label, oldValue, units, onChange }: Props) => {
  const [value, setValue] = useState<string>("");

  useEffect(() => {
    if (oldValue) {
      setValue(oldValue.toString());
    }
  }, [oldValue]);

  const onChangeHandler = (value: string) => {
    setValue(value);
    onChange(Number.parseFloat(value));
  };

  return (
    <TextFieldMUI
      autoFocus={autoFocus}
      label={label}
      value={value}
      type={"number"}
      sx={{ width: 250 }}
      InputProps={{ endAdornment: <InputAdornment position="end">{units}</InputAdornment> }}
      onChange={(event) => {
        onChangeHandler(event.target.value);
      }}
    />
  );
};

export default NumberField;
