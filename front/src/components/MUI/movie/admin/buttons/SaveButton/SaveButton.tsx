import Button from "@mui/material/Button";
import { GeneralProps } from "../structure";

const SaveButton = ({ onClick }: GeneralProps) => {
  return (
    <Button size="small" variant="contained" color="success" onClick={onClick}>
      Сохранить
    </Button>
  );
};

export default SaveButton;
