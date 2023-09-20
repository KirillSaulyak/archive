import Typography from "@mui/material/Typography";
import Grid from '@mui/material/Unstable_Grid2';
import BackButton from "../buttons/BackButton";
import { TitleWithBackButtonProps } from "./types";

export default function TitleWithBackButton(props: TitleWithBackButtonProps) {
    return (
        <Grid container mt={3} >
            <Grid xs={4}>
                <BackButton />
            </Grid>
            <Grid>
                <Typography variant="h3">{props.children}</Typography>
            </Grid>
        </Grid>

    )
}