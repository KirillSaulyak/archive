import Grid from '@mui/material/Grid';
import { commonGridProps } from "../../types";

const Column = (props: commonGridProps) => {
    return (
        <Grid>
            {props.children}
        </Grid>
    )
}

export default Column;