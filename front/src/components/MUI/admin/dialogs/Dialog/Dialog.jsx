import DialogMUI from '@mui/material/Dialog';
import DialogActions from '@mui/material/DialogActions';
import DialogContent from '@mui/material/DialogContent';
import DialogTitle from '@mui/material/DialogTitle';
import Button from "@mui/material/Button";
// import TextField from "@mui/material/TextField";

import { useState } from 'react';

import { dialogProps } from "./types";

const Dialog = ({ labelButton = null, title, content, onChange, onClickSave, childrenContent }) => {//props:dialogProps) {
    const [open, setOpen] = useState(false);

    const handleClickOpen = () => {
        setOpen(true);
    };

    const handleClose = () => {
        setOpen(false);
    };
    const handleClickSave = () => {
        handleClose();
        onClickSave();
    }

    return (
        <>
            <Button
                size="small"
                variant="text"
                onClick={handleClickOpen}
            >
                {labelButton}
            </Button>
            <DialogMUI
                open={open}
                onClose={handleClose}
            >
                <DialogTitle>
                    {title}
                </DialogTitle>
                <DialogContent>
                    {childrenContent}
                </DialogContent>
                <DialogActions>
                    <Button
                        color="inherit"
                        onClick={handleClose}
                    >
                        Отмена
                    </Button>
                    <Button
                        color="success"
                        onClick={handleClickSave}
                    >
                        Сохранить
                    </Button>
                </DialogActions>
            </DialogMUI>
        </>
    )
}
export default Dialog;