import { Grid } from '../importsCommon';
import { commonGridProps } from "../types";

export default function Column(props: commonGridProps) {
    return (
        <Grid>
            {props.children}
        </Grid>
    )
}