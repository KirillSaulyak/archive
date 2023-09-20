import DialogMUI from '@mui/material/Dialog';
import DialogActions from '@mui/material/DialogActions';
import DialogContent from '@mui/material/DialogContent';
import DialogTitle from '@mui/material/DialogTitle';
import TextField from "@mui/material/TextField";
import React from "react";
import Button from "@mui/material/Button";
import {dialogProps} from "./types";

export default function Dialog(props:dialogProps) {
    const [open, setOpen] = React.useState(false);

    const handleClickOpen = () => {
        setOpen(true);
    };

    const handleClose = () => {
        setOpen(false);
    };

    return (
        <>
        <Button size="small" variant="text" onClick={handleClickOpen}>{props.labelButton}</Button>
        <DialogMUI open={open} onClose={handleClose}>
            <DialogTitle>{props.title}</DialogTitle>
            <DialogContent>
                <TextField
                    autoFocus
                    margin="dense"
                    label={props.content}
                    fullWidth
                    variant="standard"
                />
            </DialogContent>
            <DialogActions>
                <Button color="inherit" onClick={handleClose}>Отмена</Button>
                <Button color="success" onClick={handleClose}>Сохранить</Button>
            </DialogActions>
        </DialogMUI>
        </>
    )
}