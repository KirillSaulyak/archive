interface GeneralTranslatorForm {
  id: string;
  fullName: string;
}

export interface TranslatorShortInfo extends GeneralTranslatorForm {}

export interface TranslatorCreateForm extends Omit<GeneralTranslatorForm, "id"> {}
