import Button from "@mui/material/Button";

export default function SaveButton({ onClick }) {
    return (
        <Button
            size="small"
            variant="contained"
            color="success"
            onClick={onClick}
        >
            Сохранить
        </Button>
    )
}