import Dialog from '@/MUI/admin/dialogs/Dialog';
import { useState } from 'react';
import { usePostActorMutation } from '@/store/api/admin/movie/actor';
import useHandleInputChange from '../../../../../hooks/useHandleInputChange';
import TextField from "@mui/material/TextField";

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
        >
            <TextField
                autoFocus
                margin="dense"
                label={'content'}
                onChange={(event) => onChange(event.target.value)}
                fullWidth
                variant="standard"
            />
        </Dialog>
    )
}

