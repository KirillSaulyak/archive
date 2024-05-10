import TextFieldMUI from "@mui/material/TextField";
import { TextFieldProps } from "../types";

import { useEffect, useState } from 'react';

const TextField = ({ label, oldValue, onChange }) => {

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
            sx={{ width: 250 }}
            onChange={(event) => { onChangeHandler(event.target.value) }}
        />
    )
}

export default TextField;