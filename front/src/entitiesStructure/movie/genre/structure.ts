interface GeneralGenreForm {
  id: string;
  name: string;
}

export interface GenreShortInfo extends GeneralGenreForm {}

export interface GenreCreateForm extends Omit<GeneralGenreForm, "id"> {}
