import { createApi, fetchBaseQuery } from "@reduxjs/toolkit/query/react";

import { BASE_URL_ADMIN } from "@config/links";

import { TranslatorShortInfo } from "@/entitiesStructure/movie/translator";

export const translatorApi = createApi({
  reducerPath: "translatorApi",
  baseQuery: fetchBaseQuery({ baseUrl: BASE_URL_ADMIN }),
  tagTypes: ["Translators"],
  endpoints: (builder) => ({
    getTranslators: builder.query<TranslatorShortInfo[], void>({
      query: () => "/translators",
      providesTags: ["Translators"],
    }),
    postTranslator: builder.mutation({
      query: (translator) => ({
        url: "/translators",
        method: "POST",
        body: translator,
      }),
      invalidatesTags: ["Translators"],
    }),
  }),
});

export const { useGetTranslatorsQuery, usePostTranslatorMutation } = translatorApi;
