import TextFieldMUI from "@mui/material/TextField";
import InputAdornment from '@mui/material/InputAdornment';
import { NumberFieldProps } from "../types";

import { useEffect, useState } from 'react';

const NumberField = ({ label, oldValue, units, onChange }) => {

    const [value, setValue] = useState('');

    useEffect(() => {
        setValue(oldValue);
    }, [oldValue]);

    const onChangeHandler = (value) => {
        setValue(value);
        onChange(value);
    };

    return (
        <TextFieldMUI
            label={label}
            value={value}
            type={'number'}
            sx={{ width: 250 }}
            InputProps={{ endAdornment: <InputAdornment position="end">{units}</InputAdornment> }}
            onChange={(event) => { onChangeHandler(event.target.value) }}
        />
    )
}

export default NumberField;