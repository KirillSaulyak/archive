import Button from "@mui/material/Button";
import ArrowBackIosNewIcon from "@mui/icons-material/ArrowBackIosNew";

const BackButton = () => {
  return (
    <Button variant="contained" color="inherit" startIcon={<ArrowBackIosNewIcon />}>
      Назад
    </Button>
  );
};

export default BackButton;
