import Dialog from '@/MUI/admin/dialogs/Dialog';
import { useState } from 'react';
import { usePostTypeMutation } from '@/store/api/admin/movie/type';
import useHandleInputChange from '../../../../../hooks/useHandleInputChange';
import TextField from "@mui/material/TextField";

export default function TypeCreate() {//props:dialogProps) {
    const [postType] = usePostTypeMutation();
    const [typeForm, setTypeForm] = useState(
        {
            name: '',
        }
    );
    const { handleInputChange } = useHandleInputChange(typeForm, setTypeForm);

    // const useHandleInputChange = (form, setForm) => {
    //     const handleInputChange = (variableName) => (newValue) => {
    //         setForm({
    //             ...form,
    //             [variableName]: newValue,
    //         });
    //     };
    
    //     return { handleInputChange }
    // }
    
    const saveNewType = () => {
        postType(typeForm)
    };

    return (
        <Dialog
            labelButton='Создать новый тип'
            content='Новый тип'
            title='Создать новый тип кино'
            childrenContent={<TextField
                        autoFocus
                        margin="dense"
                        label={'content'}
                        onChange={(event) => onChange(event.target.value)}
                        fullWidth
                        variant="standard"
                    />}
            onChange={handleInputChange('name')}
            onClickSave={saveNewType}
        />
    )
}

