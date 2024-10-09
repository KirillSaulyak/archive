import Dialog from "@/components/MUI/movie/admin/dialogs/DialogForm";
import TextFieldDialog from "@/components/MUI/movie/admin/fields/TextFieldDialog";

import { useState } from "react";

import { usePostActorMutation } from "@store/api/movie/admin/actor";

import handleInputChange from "@/utils/handleInputChange";

import { ActorCreateForm } from "@/entitiesStructure/movie/actor";

export default function ActorCreate() {
  const [postActor] = usePostActorMutation();
  const [actorForm, setActorForm] = useState<ActorCreateForm>({
    fullName: "",
  });

  const saveNewActor = () => {
    postActor(actorForm);
  };

  return (
    <Dialog
      labelOpenDialogButton="Создать нового актера"
      title="Создать нового актера"
      onClickSave={saveNewActor}
      dialogFormContent={
        <TextFieldDialog label="Фамилия и имя актера" onChange={handleInputChange(setActorForm)("fullName")} />
      }
    />
  );
}
