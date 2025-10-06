import Grid from "@mui/material/Grid";

import { GeneralProps } from "../../structure";

const RowCenter = (props: GeneralProps) => {
  return (
    <Grid container justifyContent="center" mt={3} columnGap={9} rowGap={3}>
      {props.children}
    </Grid>
  );
};

export default RowCenter;
