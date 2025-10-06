import AutocompleteMUI from "@mui/material/Autocomplete";

import { Props } from "./structure";

import { Option } from "../structure";

import { useState, useEffect } from "react";

import TextFieldAutocomplete from "@components/MUI/movie/admin/fields/TextFieldAutocomplete";

const AutocompleteMultiple = ({ oldValueIds = [], options = [], label, onChange }: Props) => {
  const [selectedValues, setSelectedValues] = useState<Option[]>([]);

  useEffect(() => {
    if (options.length > 0 && oldValueIds.length > 0 && selectedValues.length === 0) {
      setSelectedValues(options.filter((option) => oldValueIds.includes(option.id)));
    }
  }, [options, oldValueIds]);

  const onChangeHandler = (values: Option[]) => {
    setSelectedValues(values);
    onChange(values.map((value) => value.id));
  };

  return (
    <AutocompleteMUI
      disablePortal
      options={options}
      getOptionLabel={(option) => option.name}
      sx={{ width: 250 }}
      value={selectedValues}
      multiple={true}
      isOptionEqualToValue={(option, value) => option.id === value.id}
      onChange={(event, value) => {
        onChangeHandler(value);
      }}
      renderInput={(params) => <TextFieldAutocomplete params={params} label={label} />}
    />
  );
};
export default AutocompleteMultiple;
