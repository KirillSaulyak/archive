import Grid from '@mui/material/Grid';
import { commonGridProps } from "../../types";

export default function RowCenter(props: commonGridProps) {
    return (
        <Grid
            container
            justifyContent="center"
            mt={3}
            columnGap={9}
            rowGap={3}
        >
            {props.children}
        </Grid>
    )
}