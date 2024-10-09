import TextFieldMUI from "@mui/material/TextField";

import { GeneralProps } from "../structure";

import { useEffect, useState } from "react";

const TextField = ({ autoFocus = false, label, oldValue, onChange }: GeneralProps) => {
  const [value, setValue] = useState<string>("");

  useEffect(() => {
    if (oldValue) {
      setValue(oldValue);
    }
  }, [oldValue]);

  const onChangeHandler = (value: string) => {
    setValue(value);
    onChange(value);
  };

  return (
    <TextFieldMUI
      autoFocus={autoFocus}
      label={label}
      value={value}
      sx={{ width: 250 }}
      onChange={(event) => {
        onChangeHandler(event.target.value);
      }}
    />
  );
};

export default TextField;
