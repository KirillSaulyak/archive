import { createApi, fetchBaseQuery } from "@reduxjs/toolkit/query/react";

import { BASE_URL_ADMIN } from "@config/links";

import { TypeShortInfo } from "@/entitiesStructure/movie/type";

export const typeApi = createApi({
  reducerPath: "typeApi",
  baseQuery: fetchBaseQuery({ baseUrl: BASE_URL_ADMIN }),
  tagTypes: ["Types"],
  endpoints: (builder) => ({
    getTypes: builder.query<TypeShortInfo[], void>({
      query: () => "/types",
      providesTags: ["Types"],
    }),
    postType: builder.mutation({
      query: (type) => ({
        url: "/types",
        method: "POST",
        body: type,
      }),
      invalidatesTags: ["Types"],
    }),
  }),
});

export const { useGetTypesQuery, usePostTypeMutation } = typeApi;
