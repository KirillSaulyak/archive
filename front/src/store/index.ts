import { configureStore } from '@reduxjs/toolkit';
import { movieReducer, movieMiddleware } from './movie';

const store = configureStore({
  reducer: { ...movieReducer },
  middleware: getDefaultMiddleware => {
    return getDefaultMiddleware().concat(
      movieMiddleware
    )
  },
  devTools: process.env.NODE_ENV !== 'production'
});

export default store;