import Grid from '@mui/material/Unstable_Grid2';
import {subRowProps} from "./types";

export default function SubRow(props:subRowProps) {
    return (
        <Grid container justifyContent="center">
            {props.children}
        </Grid>
    )
}