import Grid from "@mui/material/Grid";

import { GeneralProps } from "../../structure";

const SubRowCenter = (props: GeneralProps) => {
  return (
    <Grid container justifyContent="center">
      {props.children}
    </Grid>
  );
};

export default SubRowCenter;
