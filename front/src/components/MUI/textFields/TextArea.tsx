import TextField from "@mui/material/TextField";
import { TextAreaProps } from "./types";

export default function TextArea(props: TextAreaProps) {
    return (
        <TextField
            label={props.label}
            sx={{ width: 700 }}
            name={props.name}
            value={props.value}
            onChange={(event) => props.onChange(event.target.value)}
            multiline
        />
    )
}