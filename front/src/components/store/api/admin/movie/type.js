import { createApi, fetchBaseQuery } from '../../importsCommon';
import { BASE_URL_ADMIN } from '../../../../config/links';

export const typeApi = createApi({
  reducerPath: 'typeApi',
  baseQuery: fetchBaseQuery({ baseUrl: BASE_URL_ADMIN }),
  tagTypes: ['Types'],
  endpoints: builder => (
    {
      getTypes: builder.query({
        query: () => '/types',
        providesTags: ['Types']
      }),
      postType: builder.mutation({
        query: (type) => ({
          url: '/types',
          method: 'POST',
          body: type
        }),
        invalidatesTags: ['Types']
      }),
    }
  )
});

export const {
  useGetTypesQuery,
  usePostTypeMutation,
} = typeApi;