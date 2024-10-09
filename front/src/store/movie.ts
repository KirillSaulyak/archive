import { actorApi } from "./api/movie/admin/actor";
import { countryApi } from "./api/movie/admin/country";
import { directorApi } from "./api/movie/admin/director";
import { genreApi } from "./api/movie/admin/genre";
import { movieApi } from "./api/movie/admin/movie";
import { themeApi } from "./api/movie/admin/theme";
import { translatorApi } from "./api/movie/admin/translator";
import { typeApi } from "./api/movie/admin/type";

export const movieReducer = {
  [movieApi.reducerPath]: movieApi.reducer,
  [actorApi.reducerPath]: actorApi.reducer,
  [countryApi.reducerPath]: countryApi.reducer,
  [directorApi.reducerPath]: directorApi.reducer,
  [genreApi.reducerPath]: genreApi.reducer,
  [themeApi.reducerPath]: themeApi.reducer,
  [translatorApi.reducerPath]: translatorApi.reducer,
  [typeApi.reducerPath]: typeApi.reducer,
};

export const movieMiddleware = [
  actorApi.middleware,
  countryApi.middleware,
  directorApi.middleware,
  genreApi.middleware,
  movieApi.middleware,
  themeApi.middleware,
  translatorApi.middleware,
  typeApi.middleware,
];
