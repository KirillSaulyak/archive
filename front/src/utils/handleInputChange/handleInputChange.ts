import { HandleInputChange } from "./structure";

const handleInputChange: HandleInputChange = (setForm) => (variableName) => (newValue) => {
  setForm((prevState) => {
    return {
      ...prevState,
      [variableName]: newValue,
    };
  });
};

export default handleInputChange;
