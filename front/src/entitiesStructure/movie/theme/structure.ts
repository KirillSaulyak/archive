interface GeneralThemeForm {
  id: string;
  name: string;
}

export interface ThemeShortInfo extends GeneralThemeForm {}

export interface ThemeCreateForm extends Omit<GeneralThemeForm, "id"> {}
