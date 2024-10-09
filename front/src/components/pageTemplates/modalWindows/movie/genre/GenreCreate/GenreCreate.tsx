import Dialog from "@/components/MUI/movie/admin/dialogs/DialogForm";
import TextFieldDialog from "@/components/MUI/movie/admin/fields/TextFieldDialog";

import { useState } from "react";

import { usePostGenreMutation } from "@store/api/movie/admin/genre";

import handleInputChange from "@/utils/handleInputChange";

import { GenreCreateForm } from "@/entitiesStructure/movie/genre";

export default function GenreCreate() {
  const [postGenre] = usePostGenreMutation();
  const [genreForm, setGenreForm] = useState<GenreCreateForm>({
    name: "",
  });

  const saveNewGenre = () => {
    postGenre(genreForm);
  };

  return (
    <Dialog
      labelOpenDialogButton="Создать новый жанр"
      title="Создать новый жанр"
      onClickSave={saveNewGenre}
      dialogFormContent={<TextFieldDialog label="Новый жанр" onChange={handleInputChange(setGenreForm)("name")} />}
    />
  );
}
