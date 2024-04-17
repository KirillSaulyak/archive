const useHandleInputChange = (form, setForm) => {
    const handleInputChange = (variableName) => (newValue) => {
        console.log(variableName, newValue)
        setForm({
            ...form,
            [variableName]: newValue,
        });
    };

    return { handleInputChange }
}

export default useHandleInputChange;