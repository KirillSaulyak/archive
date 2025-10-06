import { MovieCreateForm, MovieUpdateForm } from "@entitiesStructure/movie/movie";

export interface Props {
  handleInputChange<K extends keyof MovieCreateForm>(variableName: K): (newValue: MovieCreateForm[K]) => void;

  handleInputChange<K extends keyof MovieUpdateForm>(variableName: K): (newValue: MovieUpdateForm[K]) => void;

  oldMovieForm?: MovieUpdateForm | undefined;
}
