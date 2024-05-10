import Button from "@mui/material/Button";

const SaveButton = ({ onClick }) => {
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

export default SaveButton;