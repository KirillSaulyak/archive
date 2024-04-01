import Button from "@mui/material/Button";
import ArrowBackIosNewIcon from '@mui/icons-material/ArrowBackIosNew';

export default function BackButton() {
    return (
        <Button
            variant="contained"
            color="inherit"
            startIcon={<ArrowBackIosNewIcon />}
        >
            Назад
        </Button>
    )
}