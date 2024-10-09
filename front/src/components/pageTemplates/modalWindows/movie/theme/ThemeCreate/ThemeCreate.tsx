import Dialog from "@/components/MUI/movie/admin/dialogs/DialogForm";
import TextFieldDialog from "@/components/MUI/movie/admin/fields/TextFieldDialog";

import { useState } from "react";

import { usePostThemeMutation } from "@store/api/movie/admin/theme";

import handleInputChange from "@/utils/handleInputChange";

import { ThemeCreateForm } from "@/entitiesStructure/movie/theme";

export default function ThemeCreate() {
  const [postTheme] = usePostThemeMutation();
  const [themeForm, setThemeForm] = useState<ThemeCreateForm>({
    name: "",
  });

  const saveNewTheme = () => {
    postTheme(themeForm);
  };

  return (
    <Dialog
      labelOpenDialogButton="Создать новую тему"
      title="Создать новую тему"
      onClickSave={saveNewTheme}
      dialogFormContent={<TextFieldDialog label="Новая тема" onChange={handleInputChange(setThemeForm)("name")} />}
    />
  );
}
