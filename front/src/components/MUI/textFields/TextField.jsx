import TextFieldMUI from "@mui/material/TextField";
import InputAdornment from '@mui/material/InputAdornment';
import { TextFieldProps } from "./types";

export default function TextField({ label, value, isNumber, onChange }) {
    return (
        <TextFieldMUI
            label={label}
            value={value}
            type={isNumber ? 'number' : 'text'}
            sx={{ width: 250 }}
            InputProps={isNumber ? { endAdornment: <InputAdornment position="end">Минут</InputAdornment> } : {}}
            onChange={(event) => onChange(event.target.value)}
        />
    )
}