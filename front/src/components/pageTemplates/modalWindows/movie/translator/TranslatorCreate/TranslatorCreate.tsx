import Dialog from "@/components/MUI/movie/admin/dialogs/DialogForm";
import TextFieldDialog from "@/components/MUI/movie/admin/fields/TextFieldDialog";

import { useState } from "react";

import { usePostTranslatorMutation } from "@store/api/movie/admin/translator";

import handleInputChange from "@/utils/handleInputChange";

import { TranslatorCreateForm } from "@/entitiesStructure/movie/translator";

export default function TranslatorCreate() {
  const [postTranslator] = usePostTranslatorMutation();
  const [translatorForm, setTranslatorForm] = useState<TranslatorCreateForm>({
    fullName: "",
  });

  const saveNewTranslator = () => {
    postTranslator(translatorForm);
  };

  return (
    <Dialog
      labelOpenDialogButton="Создать нового переводчика"
      title="Создать нового переводчика"
      onClickSave={saveNewTranslator}
      dialogFormContent={
        <TextFieldDialog label="Новый переводчик" onChange={handleInputChange(setTranslatorForm)("fullName")} />
      }
    />
  );
}
