import DialogMUI from "@mui/material/Dialog";
import DialogActions from "@mui/material/DialogActions";
import DialogContent from "@mui/material/DialogContent";
import DialogTitle from "@mui/material/DialogTitle";

import SaveButton from "@/components/MUI/movie/admin/buttons/dialogButtons/SaveButton";
import CancelButton from "@/components/MUI/movie/admin/buttons/dialogButtons/CancelButton";
import OpenDialogButton from "@/components/MUI/movie/admin/buttons/dialogButtons/OpenDialogButton/OpenDialogButton";

import { useState } from "react";

import { Props } from "./structure";

const DialogForm = ({ labelOpenDialogButton, title, dialogFormContent, onClickSave }: Props) => {
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
  };

  return (
    <>
      <OpenDialogButton label={labelOpenDialogButton} onClick={handleClickOpen} />
      <DialogMUI open={open} onClose={handleClose}>
        <DialogTitle>{title}</DialogTitle>
        <DialogContent>{dialogFormContent}</DialogContent>
        <DialogActions>
          <CancelButton onClick={handleClose} />
          <SaveButton onClick={handleClickSave} />
        </DialogActions>
      </DialogMUI>
    </>
  );
};
export default DialogForm;
