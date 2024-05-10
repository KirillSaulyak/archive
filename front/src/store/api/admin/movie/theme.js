import { createApi, fetchBaseQuery } from '@reduxjs/toolkit/query/react';
import { BASE_URL_ADMIN } from '../../../../config/links';

export const themeApi = createApi({
  reducerPath: 'themeApi',
  baseQuery: fetchBaseQuery({ baseUrl: BASE_URL_ADMIN }),
  tagTypes: ['Themes'],
  endpoints: builder => (
    {
      getThemes: builder.query({
        query: () => '/themes',
        providesTags: ['Themes']
      }),
      postTheme: builder.mutation({
        query: (theme) => ({
          url: '/themes',
          method: 'POST',
          body: theme
        }),
        invalidatesTags: ['Themes']
      }),
    }
  )
});

export const {
  useGetThemesQuery,
  usePostThemeMutation,
} = themeApi;