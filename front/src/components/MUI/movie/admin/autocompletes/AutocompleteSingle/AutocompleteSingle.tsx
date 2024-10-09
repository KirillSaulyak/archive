import AutocompleteMUI from "@mui/material/Autocomplete";

import { useState, useEffect } from "react";

import { Props } from "./structure";

import { Option } from "../structure";

import TextFieldAutocomplete from "@components/MUI/movie/admin/fields/TextFieldAutocomplete";

const AutocompleteSingle = ({ oldValueId, options = [], label, onChange }: Props) => {
  const [selectedValue, setSelectedValue] = useState<Option | null>(null);

  useEffect(() => {
    if (options.length > 0 && oldValueId && !selectedValue) {
      const selectedOption: Option | undefined = options.find((option: Option) => oldValueId === option.id);
      if (selectedOption) {
        setSelectedValue(selectedOption);
      }
    }
  }, [options, oldValueId]);

  const onChangeHandler = (value: Option) => {
    setSelectedValue(value);
    onChange(value.id);
  };

  return (
    <AutocompleteMUI
      disablePortal
      options={options}
      getOptionLabel={(option) => option.name}
      isOptionEqualToValue={(option, value) => option.id === value.id}
      sx={{ width: 250 }}
      value={selectedValue}
      onChange={(event, value) => {
        if (value) {
          onChangeHandler(value);
        }
      }}
      renderInput={(params) => <TextFieldAutocomplete params={params} label={label} />}
    />
  );
};
export default AutocompleteSingle;
