import Dialog from '../../../MUI/dialogs/Dialog';
import { useState } from '../commonImports';
import { usePostTranslatorMutation } from '../../../store/api/admin/movie/translator';
import useHandleInputChange from '../../../hooks/useHandleInputChange';

export default function TranslatorCreate() {//props:dialogProps) {
    const [postTranslator] = usePostTranslatorMutation();
    const [translatorForm, setTranslatorForm] = useState(
        {
            fullName: '',
        }
    );

    const { handleInputChange } = useHandleInputChange(translatorForm, setTranslatorForm);

    const saveNewTranslator = () => {
        postTranslator(translatorForm)
    };

    return (
        <Dialog
            labelButton='Создать нового переводчика'
            content='Новый переводчик'
            title='Создать нового переводчика'
            onChange={handleInputChange('fullName')}
            onClickSave={saveNewTranslator}
        />
    )
}

