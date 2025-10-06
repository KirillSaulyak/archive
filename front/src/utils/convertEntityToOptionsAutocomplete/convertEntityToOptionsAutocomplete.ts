import { ConvertEntityToOptionsAutocomplete } from "./structure";

const convertEntityToOptionsAutocomplete: ConvertEntityToOptionsAutocomplete = (entities, fieldName) => {
  return entities.map((entity) => ({ id: entity.id, name: String(entity[fieldName]) }));
};

export default convertEntityToOptionsAutocomplete;
