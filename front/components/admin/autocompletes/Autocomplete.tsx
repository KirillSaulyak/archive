import AutocompleteMUI from "@mui/material/Autocomplete";
import TextField from "@mui/material/TextField";
import {autocompleteProps} from "./types";

export default function Autocomplete(props:autocompleteProps) {
    return (
        <AutocompleteMUI
            disablePortal
            id="combo-box-demo"
            options={props.options}
            sx={{ width: 200}}
            renderInput={
                (params) =>
                <TextField {...params} label={props.label}/>
                }
        />
        )
}