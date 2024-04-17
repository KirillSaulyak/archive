import TextFieldMUI from "@mui/material/TextField";
import InputAdornment from '@mui/material/InputAdornment';
import { TextFieldProps } from "./types";

import { useEffect, useState } from 'react';

export default function TextField({ label, oldValue, isNumber, onChange }) {

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
            type={isNumber ? 'number' : 'text'}
            sx={{ width: 250 }}
            InputProps={isNumber ? { endAdornment: <InputAdornment position="end">Минут</InputAdornment> } : {}}
            onChange={(event) => { onChangeHandler(event.target.value) }}
        />
    )
}