interface GeneralDirectorForm {
  id: string;
  fullName: string;
}

export interface DirectorShortInfo extends GeneralDirectorForm {}

export interface DirectorCreateForm extends Omit<GeneralDirectorForm, "id"> {}
