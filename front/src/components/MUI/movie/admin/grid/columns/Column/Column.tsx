import Grid from "@mui/material/Grid";

import { GeneralProps } from "../../structure";

const Column = ({ children }: GeneralProps) => {
  return <Grid>{children}</Grid>;
};

export default Column;
