interface GeneralActorForm {
  id: string;
  fullName: string;
}

export interface ActorShortInfo extends GeneralActorForm {}

export interface ActorCreateForm extends Omit<GeneralActorForm, "id"> {}
