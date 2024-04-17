import Dialog from '@/MUI/dialogs/Dialog';
import { useState } from '../commonImports';
import { usePostDirectorMutation } from '@/store/api/admin/movie/director';
import useHandleInputChange from '@/hooks/useHandleInputChange';

export default function DirectorCreate() {//props:dialogProps) {
    const [postDirector] = usePostDirectorMutation();
    const [directorForm, setDirectorForm] = useState(
        {
            fullName: '',
        }
    );

    const { handleInputChange } = useHandleInputChange(directorForm, setDirectorForm);

    const saveNewDirector = () => {
        postDirector(directorForm)
    };

    return (
        <Dialog
            labelButton='Создать нового режиссера'
            content='Новый режиссер'
            title='Создать нового режиссера'
            onChange={handleInputChange('fullName')}
            onClickSave={saveNewDirector}
        />
    )
}