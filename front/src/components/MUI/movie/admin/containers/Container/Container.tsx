import { default as ContainerMUI } from "@mui/material/Container";

import { GeneralProps } from "../structure";

const Container = ({ children }: GeneralProps) => {
  return <ContainerMUI>{children}</ContainerMUI>;
};

export default Container;
