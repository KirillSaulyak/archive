import Dialog from "@/components/MUI/movie/admin/dialogs/DialogForm";
import TextFieldDialog from "@/components/MUI/movie/admin/fields/TextFieldDialog";

import { useState } from "react";

import { usePostTypeMutation } from "@store/api/movie/admin/type";

import handleInputChange from "@/utils/handleInputChange";

import { TypeCreateForm } from "@/entitiesStructure/movie/type";

export default function TypeCreate() {
  const [postType] = usePostTypeMutation();
  const [typeForm, setTypeForm] = useState<TypeCreateForm>({
    name: "",
  });

  const saveNewType = () => {
    postType(typeForm);
  };

  return (
    <Dialog
      labelOpenDialogButton="Создать новый тип"
      title="Создать новый тип кино"
      onClickSave={saveNewType}
      dialogFormContent={<TextFieldDialog label="Новый тип" onChange={handleInputChange(setTypeForm)("name")} />}
    />
  );
}
