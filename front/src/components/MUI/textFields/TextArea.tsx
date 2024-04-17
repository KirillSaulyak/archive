import TextField from "@mui/material/TextField";
import { TextAreaProps } from "./types";
import { useEffect, useState } from 'react';

export default function TextArea(props: TextAreaProps) {
    
    const [value, setValue] = useState('');

    useEffect(() => {
        setValue(props.oldValue);
    }, [props.oldValue]);

    const onChangeHandler = (value:string) => {
        setValue(value);
        props.onChange(value);
    };

    return (
        <TextField
            label={props.label}
            sx={{ width: 700 }}
            name={props.name}
            value={value}
            onChange={(event) =>  onChangeHandler(event.target.value) }
            multiline
        />
    )
}