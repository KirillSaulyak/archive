interface GeneralTypeForm {
  id: string;
  name: string;
}

export interface TypeShortInfo extends GeneralTypeForm {}

export interface TypeCreateForm extends Omit<GeneralTypeForm, "id"> {}
