import TextFieldMUI from "@mui/material/TextField";
import { TextFieldProps } from "./types";

export default function TextField(props: TextFieldProps) {
    return (
        <TextFieldMUI label={props.label} sx={{ width: 200 }} />
    )
}