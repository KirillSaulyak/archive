import Button from "@mui/material/Button";

import { Props } from "./structure";

const OpenDialogButton = ({ label, onClick }: Props) => {
  return (
    <Button size="small" variant="text" onClick={onClick}>
      {label}
    </Button>
  );
};

export default OpenDialogButton;
