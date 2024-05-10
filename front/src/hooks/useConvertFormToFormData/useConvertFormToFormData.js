const useConvertFormToFormData = (userForm = {}, fileFields = []) => {
  const formData = new FormData();

  const formToSend = Object.keys(userForm).reduce((object, key) => {
    if (!fileFields.includes(key)) {
      object[key] = userForm[key];
    }
    else {
      formData.append(key, userForm[key]);
    }
    return object;
  }, {});

  const json = JSON.stringify(formToSend);
  formData.append("json", new Blob(([json]), { type: 'application/json' }));
  return formData;
}

export default useConvertFormToFormData;