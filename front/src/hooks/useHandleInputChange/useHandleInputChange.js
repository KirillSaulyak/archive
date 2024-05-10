const useHandleInputChange = (form, setForm) => {
    const handleInputChange = (variableName) => (newValue) => {
        setForm({
            ...form,
            [variableName]: newValue,
        });
    };

    return { handleInputChange }
}

export default useHandleInputChange;