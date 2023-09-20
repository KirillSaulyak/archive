import TextField from "@mui/material/TextField";
import { TextAreaProps } from "./types";

export default function TextArea(props: TextAreaProps) {
    return (
        <TextField
            label={props.label}
            multiline
            sx={{ width: 700 }}
        />
    )
}