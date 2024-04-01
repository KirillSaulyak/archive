import { createApi, fetchBaseQuery } from '../../importsCommon';
import { BASE_URL_ADMIN } from '../../../../config/links';

export const translatorApi = createApi({
  reducerPath: 'translatorApi',
  baseQuery: fetchBaseQuery({ baseUrl: BASE_URL_ADMIN }),
  tagTypes: ['Translators'],
  endpoints: builder => (
    {
      getTranslators: builder.query({
        query: () => '/translators',
        providesTags: ['Translators']
      }),
      postTranslator: builder.mutation({
        query: (translator) => ({
          url: '/translators',
          method: 'POST',
          body: translator
        }),
        invalidatesTags: ['Translators']
      }),
    }
  )
});

export const {
  useGetTranslatorsQuery,
  usePostTranslatorMutation,
} = translatorApi;