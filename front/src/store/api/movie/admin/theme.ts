import { createApi, fetchBaseQuery } from "@reduxjs/toolkit/query/react";

import { BASE_URL_ADMIN } from "@config/links";

import { ThemeShortInfo } from "@/entitiesStructure/movie/theme";

export const themeApi = createApi({
  reducerPath: "themeApi",
  baseQuery: fetchBaseQuery({ baseUrl: BASE_URL_ADMIN }),
  tagTypes: ["Themes"],
  endpoints: (builder) => ({
    getThemes: builder.query<ThemeShortInfo[], void>({
      query: () => "/themes",
      providesTags: ["Themes"],
    }),
    postTheme: builder.mutation({
      query: (theme) => ({
        url: "/themes",
        method: "POST",
        body: theme,
      }),
      invalidatesTags: ["Themes"],
    }),
  }),
});

export const { useGetThemesQuery, usePostThemeMutation } = themeApi;
