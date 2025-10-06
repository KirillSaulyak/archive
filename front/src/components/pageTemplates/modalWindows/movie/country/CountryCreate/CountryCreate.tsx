import Dialog from "@/components/MUI/movie/admin/dialogs/DialogForm";
import TextFieldDialog from "@/components/MUI/movie/admin/fields/TextFieldDialog";

import { useState } from "react";

import { usePostCountryMutation } from "@store/api/movie/admin/country";

import handleInputChange from "@/utils/handleInputChange";

import { CountryCreateForm } from "@/entitiesStructure/movie/country";

export default function CountryCreate() {
  const [postCountry] = usePostCountryMutation();
  const [countryForm, setCountryForm] = useState<CountryCreateForm>({
    name: "",
  });

  const saveNewCountry = () => {
    postCountry(countryForm);
  };

  return (
    <Dialog
      labelOpenDialogButton="Создать новую страну"
      title="Создать новую страну"
      onClickSave={saveNewCountry}
      dialogFormContent={<TextFieldDialog label="Новая страна" onChange={handleInputChange(setCountryForm)("name")} />}
    />
  );
}
