import Dialog from '@/MUI/admin/dialogs/Dialog';
import { useState } from 'react';
import { usePostThemeMutation } from '@/store/api/admin/movie/theme';
import useHandleInputChange from '../../../../../hooks/useHandleInputChange';

export default function ThemeCreate() {//props:dialogProps) {
    const [postTheme] = usePostThemeMutation();
    const [themeForm, setThemeForm] = useState(
        {
            name: '',
        }
    );

    const { handleInputChange } = useHandleInputChange(themeForm, setThemeForm);

    const saveNewTheme = () => {
        postTheme(themeForm)
    };

    return (
        <Dialog
            labelButton='Создать новую тему'
            content='Новая тема'
            title='Создать новую тему'
            onChange={handleInputChange('name')}
            onClickSave={saveNewTheme}
        />
    )
}

