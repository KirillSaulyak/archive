import Typography from "@mui/material/Typography";
import { GeneralProps } from "../structure";

const Title = (props: GeneralProps) => {
  return (
    <Typography align="center" variant="h3">
      {props.children}
    </Typography>
  );
};

export default Title;
