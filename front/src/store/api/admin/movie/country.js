import { createApi, fetchBaseQuery } from '@reduxjs/toolkit/query/react';
import { BASE_URL_ADMIN } from '../../../../config/links';

export const countryApi = createApi({
  reducerPath: 'countryApi',
  baseQuery: fetchBaseQuery({ baseUrl: BASE_URL_ADMIN }),
  tagTypes: ['Countries'],
  endpoints: builder => (
    {
      getCountries: builder.query({
        query: () => '/countries',
        providesTags: ['Countries']
      }),
      postCountry: builder.mutation({
        query: (country) => ({
          url: '/countries',
          method: 'POST',
          body: country
        }),
        invalidatesTags: ['Countries']
      }),
    }
  )
});

export const {
  useGetCountriesQuery,
  usePostCountryMutation,
} = countryApi;