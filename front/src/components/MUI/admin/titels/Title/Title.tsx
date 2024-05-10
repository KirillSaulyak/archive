import Typography from "@mui/material/Typography";
import { TitleProps } from "./types";

export default function Title(props: TitleProps) {
    return (
        <Typography
            align="center"
            variant="h3"
        >
            {props.children}
        </Typography>
    )
}