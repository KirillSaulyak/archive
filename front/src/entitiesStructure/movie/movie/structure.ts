interface GeneralMovieForm {
  id: string;
  name: string;
  nameAnother: string;
  duration: number;
  release: Date;
  typeId: string;
  countryIds: string[];
  genreIds: string[];
  translatorId: string;
  themeIds: string[];
  actorIds: string[];
  directorIds: string[];
  description: string;
}

export interface MovieCreateForm extends Omit<GeneralMovieForm, "id"> {
  poster: File | null;
}

export interface MovieUpdateForm extends GeneralMovieForm {
  poster: File | string;
}

export interface MovieInfoForm extends GeneralMovieForm {
  poster: string;
}