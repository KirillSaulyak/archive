import { Option } from "@/components/MUI/movie/admin/autocompletes/structure";

export type ConvertEntityToOptionsAutocomplete = <T extends { id: string }, K extends keyof T>(
  entities: T[],
  fieldName: K
) => Option[];
