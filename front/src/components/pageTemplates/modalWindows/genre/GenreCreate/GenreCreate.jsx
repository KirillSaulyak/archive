import Dialog from '@/MUI/admin/dialogs/Dialog';
import { useState } from 'react';
import { usePostGenreMutation } from '@/store/api/admin/movie/genre';
import useHandleInputChange from '../../../../../hooks/useHandleInputChange';

export default function GenreCreate() {//props:dialogProps) {
    const [postGenre] = usePostGenreMutation();
    const [genreForm, setGenreForm] = useState(
        {
            name: '',
        }
    );
    
    const { handleInputChange } = useHandleInputChange(genreForm, setGenreForm);

    const saveNewGenre = () => {
        postGenre(genreForm)
    };

    return (
        <Dialog
            labelButton='Создать новый жанр'
            content='Новый жанр'
            title='Создать новый жанр'
            onChange={handleInputChange('name')}
            onClickSave={saveNewGenre}
        />
    )
}