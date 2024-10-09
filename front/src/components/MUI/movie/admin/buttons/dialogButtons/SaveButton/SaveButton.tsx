import Button from "@mui/material/Button";

import { GeneralProps } from "../../structure";

const SaveButton = ({ onClick }: GeneralProps) => {
  return (
    <Button color="success" onClick={onClick}>
      Сохранить
    </Button>
  );
};

export default SaveButton;
