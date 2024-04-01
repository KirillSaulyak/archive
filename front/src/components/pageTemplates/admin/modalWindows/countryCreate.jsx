import Dialog from '../../../MUI/dialogs/Dialog';
import { useState } from '../commonImports';
import { usePostCountryMutation } from '../../../store/api/admin/movie/country';
import useHandleInputChange from '../../../hooks/useHandleInputChange';

export default function CountryCreate() {//props:dialogProps) {
    const [postCountry] = usePostCountryMutation();
    const [countryForm, setCountryForm] = useState(
        {
            name: '',
        }
    );

    const { handleInputChange } = useHandleInputChange(countryForm, setCountryForm);
    
    const saveNewCountry = () => {
        postCountry(countryForm)
    };

    return (
        <Dialog
            labelButton='Создать новую страну'
            content='Новая страна'
            title='Создать новую страну'
            onChange={handleInputChange('name')}
            onClickSave={saveNewCountry}
        />
    )
}