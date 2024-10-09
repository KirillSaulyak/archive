import Dialog from "@/components/MUI/movie/admin/dialogs/DialogForm";
import TextFieldDialog from "@/components/MUI/movie/admin/fields/TextFieldDialog";

import { useState } from "react";

import { usePostDirectorMutation } from "@store/api/movie/admin/director";

import handleInputChange from "@/utils/handleInputChange";

import { DirectorCreateForm } from "@/entitiesStructure/movie/director";

export default function DirectorCreate() {
  const [postDirector] = usePostDirectorMutation();
  const [directorForm, setDirectorForm] = useState<DirectorCreateForm>({
    fullName: "",
  });

  const saveNewDirector = () => {
    postDirector(directorForm);
  };

  return (
    <Dialog
      labelOpenDialogButton="Создать нового режиссера"
      title="Создать нового режиссера"
      onClickSave={saveNewDirector}
      dialogFormContent={
        <TextFieldDialog label="Новый режиссер" onChange={handleInputChange(setDirectorForm)("fullName")} />
      }
    />
  );
}
