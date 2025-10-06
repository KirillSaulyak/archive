import { createApi, fetchBaseQuery } from "@reduxjs/toolkit/query/react";

import { BASE_URL_ADMIN } from "@config/links";

import { MovieInfoForm } from "@/entitiesStructure/movie/movie";

export const movieApi = createApi({
  reducerPath: "movieApi",
  baseQuery: fetchBaseQuery({ baseUrl: BASE_URL_ADMIN }),
  tagTypes: ["Movies"],
  endpoints: (builder) => ({
    getMovieById: builder.query<MovieInfoForm, string>({
      query: (id) => `/movies/${id}`,
      providesTags: ["Movies"],
    }),
    postMovie: builder.mutation<void, FormData>({
      query: (movie) => ({
        url: "/movies",
        method: "POST",
        body: movie,
      }),
      invalidatesTags: ["Movies"],
    }),
    putMovie: builder.mutation<void, FormData>({
      query: (movie) => ({
        url: `/movies`,
        method: "PUT",
        body: movie,
      }),
      invalidatesTags: ["Movies"],
    }),
  }),
});

export const { useGetMovieByIdQuery, usePostMovieMutation, usePutMovieMutation } = movieApi;
