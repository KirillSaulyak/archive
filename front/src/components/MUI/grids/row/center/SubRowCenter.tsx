import { Grid } from '../../importsCommon';
import { commonGridProps } from "../../types";

export default function SubRowCenter(props: commonGridProps) {
    return (
        <Grid container justifyContent="center">
            {props.children}
        </Grid>
    )
}