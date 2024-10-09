import { createApi, fetchBaseQuery } from "@reduxjs/toolkit/query/react";

import { BASE_URL_ADMIN } from "@config/links";

import { DirectorShortInfo } from "@/entitiesStructure/movie/director";

export const directorApi = createApi({
  reducerPath: "directorApi",
  baseQuery: fetchBaseQuery({ baseUrl: BASE_URL_ADMIN }),
  tagTypes: ["Director"],
  endpoints: (builder) => ({
    getDirectors: builder.query<DirectorShortInfo[], void>({
      query: () => "/directors",
      providesTags: ["Director"],
    }),
    postDirector: builder.mutation({
      query: (director) => ({
        url: "/directors",
        method: "POST",
        body: director,
      }),
      invalidatesTags: ["Director"],
    }),
  }),
});

export const { useGetDirectorsQuery, usePostDirectorMutation } = directorApi;
