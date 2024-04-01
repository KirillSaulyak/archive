import AutocompleteMUI from "@mui/material/Autocomplete";
import TextField from "@mui/material/TextField";
import { autocompleteProps } from "./types";
import { useState, useEffect } from 'react';
export default function Autocomplete({ valueIds, options, optionLabel, label, multiple, onChange }) {//:autocompleteProps) {

    const [selectedValues, setSelectedValues] = useState(multiple ? [] : null);

    useEffect(() => {
        if (options && valueIds) {
            if (multiple) {
                const selectedOptions = options.filter((option) => valueIds.includes(option.id));
                setSelectedValues(selectedOptions);
            }
            else {
                const selectedOption = options.find((option) => valueIds === option.id);
                setSelectedValues(selectedOption);
            }
        }
    }, [options, valueIds]);

    return (
        <AutocompleteMUI
            disablePortal
            options={options}
            getOptionLabel={(option) => option[optionLabel]}
            sx={{ width: 250 }}
            value={selectedValues}
            multiple={multiple}
            onChange={
                (event, value) => {
                    multiple ? onChange(value.map(item => item.id)) : onChange(value.id)
                }
            }
            renderInput={
                (params) =>
                    <TextField {...params} label={label} />
            }

        />
    )
}