import Dialog from '@/MUI/dialogs/Dialog';
import { useState } from '../commonImports';
import { usePostActorMutation } from '@/store/api/admin/movie/actor';
import useHandleInputChange from '@/hooks/useHandleInputChange';

export default function ActorCreate() {//props:dialogProps) {
    const [postActor] = usePostActorMutation();
    const [actorForm, setActorForm] = useState(
        {
            fullName: '',
        }
    );
    const { handleInputChange } = useHandleInputChange(actorForm, setActorForm);

    const saveNewActor = () => {
        postActor(actorForm)
    };

    return (
        <Dialog
            labelButton='Создать нового актера'
            content='Новый актер'
            title='Создать нового актера'
            onChange={handleInputChange('fullName')}
            onClickSave={saveNewActor}
        />
    )
}

