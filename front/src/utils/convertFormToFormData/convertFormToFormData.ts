import { ConvertFormToFormData } from "./structure";

const convertFormToFormData: ConvertFormToFormData = (form, fileFields = []) => {
  const formData = new FormData();
  const formToSend: { [key: string]: unknown } = {};

  for (const [key, value] of Object.entries(form)) {
    if (!fileFields.includes(key)) {
      formToSend[key] = value;
    } else {
      formData.append(key, value as File);
    }
  }

  const json = JSON.stringify(formToSend);
  formData.append("json", new Blob([json], { type: "application/json" }));
  return formData;
};

export default convertFormToFormData;
