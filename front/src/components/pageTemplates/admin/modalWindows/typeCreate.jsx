import Dialog from '../../../MUI/dialogs/Dialog';
import { useState } from '../commonImports';
import { usePostTypeMutation } from '../../../store/api/admin/movie/type';
import useHandleInputChange from '../../../hooks/useHandleInputChange';

export default function TypeCreate() {//props:dialogProps) {
    const [postType] = usePostTypeMutation();
    const [typeForm, setTypeForm] = useState(
        {
            name: '',
        }
    );
    const { handleInputChange } = useHandleInputChange(typeForm, setTypeForm);

    const saveNewType = () => {
        postType(typeForm)
    };

    return (
        <Dialog
            labelButton='Создать новый тип'
            content='Новый тип'
            title='Создать новый тип кино'
            onChange={handleInputChange('name')}
            onClickSave={saveNewType}
        />
    )
}

