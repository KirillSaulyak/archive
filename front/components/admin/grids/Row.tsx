import Grid from '@mui/material/Unstable_Grid2';
import {rowProps} from "./types";

export default function Row(props:rowProps) {
    return (
        <Grid container justifyContent="center" mt={3} columnGap={9} rowGap={3}>
            {props.children}
        </Grid>
    )
}