const useConvertFormToFormData = (userForm = {}, fileFields = []) => {
  const formData = new FormData();
  let formToSend = Object.keys(userForm).reduce((obj, key) => {
    if (!fileFields.includes(key)) {
      obj[key] = userForm[key];
    }
    else {
      formData.append(key, userForm[key]);
    }
    return obj;
  }, {});


  const json = JSON.stringify(formToSend);

  formData.append("json", new Blob(([json]), { type: 'application/json' }));

  return formData;
}

export default useConvertFormToFormData;