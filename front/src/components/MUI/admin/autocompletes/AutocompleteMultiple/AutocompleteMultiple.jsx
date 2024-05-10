import AutocompleteMUI from "@mui/material/Autocomplete";
import TextField from "@mui/material/TextField";
import { autocompleteProps } from "../../autocompletes/types";
import { useState, useEffect } from 'react';

const AutocompleteSingle = ({ valueIds, options, optionLabel, label, onChange }) => {//:autocompleteProps) {

    const [selectedValues, setSelectedValues] = useState([]);

    useEffect(() => {
        if (options && valueIds) {
            const selectedOptions = options.filter((option) => valueIds.includes(option.id));
            setSelectedValues(selectedOptions);
        }
    }, [options, valueIds]);

    const onChangeHandler = (value) => {
        setSelectedValues(value)
        onChange(value.map(item => item.id))
    };

    return (
        <AutocompleteMUI
            disablePortal
            options={options}
            getOptionLabel={(option) => option[optionLabel]}
            sx={{ width: 250 }}
            value={selectedValues}
            multiple={true}
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