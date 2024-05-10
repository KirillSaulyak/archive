import AutocompleteMUI from "@mui/material/Autocomplete";
import TextField from "@mui/material/TextField";
import { autocompleteProps } from "../types";
import { useState, useEffect } from 'react';

const AutocompleteSingle = ({ valueIds, options, optionLabel, label, onChange }) => {//:autocompleteProps) {

    const [selectedValues, setSelectedValues] = useState(null);

    useEffect(() => {
        if (options && valueIds) {
            const selectedOption = options.find((option) => valueIds === option.id);
            setSelectedValues(selectedOption);
        }
    }, [options, valueIds]);

    const onChangeHandler = (value) => {
        setSelectedValues(value)
        onChange(value.id)
    };

    return (
        <AutocompleteMUI
            disablePortal
            options={options}
            getOptionLabel={(option) => option[optionLabel]}
            sx={{ width: 250 }}
            value={selectedValues}
            onChange={
                (event, value) => {
                    onChangeHandler(value)
                }
            }
            renderInput={
                (params) =>
                    <TextField {...params} label={label} />
            }

        />
    )
}
export default AutocompleteSingle;