import Button from "@mui/material/Button";

import { GeneralProps } from "../../structure";
const CancelButton = ({ onClick }: GeneralProps) => {
  return (
    <Button color="inherit" onClick={onClick}>
      Отмена
    </Button>
  );
};

export default CancelButton;
