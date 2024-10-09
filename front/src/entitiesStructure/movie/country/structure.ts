interface GeneralCountryForm {
  id: string;
  name: string;
}

export interface CountryShortInfo extends GeneralCountryForm {}

export interface CountryCreateForm extends Omit<GeneralCountryForm, "id"> {}
