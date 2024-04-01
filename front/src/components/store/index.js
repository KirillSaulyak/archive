import { configureStore } from '@reduxjs/toolkit';
import { actorApi } from './api/admin/movie/actor';
import { countryApi } from './api/admin/movie/country';
import { directorApi } from './api/admin/movie/director';
import { genreApi } from './api/admin/movie/genre';
import { movieApi } from './api/admin/movie/movie';
import { themeApi } from './api/admin/movie/theme';
import { translatorApi } from './api/admin/movie/translator';
import { typeApi } from './api/admin/movie/type';

const store = configureStore({
  reducer: {
    [movieApi.reducerPath]: movieApi.reducer,
    [actorApi.reducerPath]: actorApi.reducer,
    [countryApi.reducerPath]: countryApi.reducer,
    [directorApi.reducerPath]: directorApi.reducer,
    [genreApi.reducerPath]: genreApi.reducer,
    [themeApi.reducerPath]: themeApi.reducer,
    [translatorApi.reducerPath]: translatorApi.reducer,
    [typeApi.reducerPath]: typeApi.reducer,
  },
  middleware: getDefaultMiddleware => {
    return getDefaultMiddleware().concat(
      actorApi.middleware,
      countryApi.middleware,
      directorApi.middleware,
      genreApi.middleware,
      movieApi.middleware,
      themeApi.middleware,
      translatorApi.middleware,
      typeApi.middleware
    )
  },
  devTools: process.env.NODE_ENV !== 'production'
});

export default store;