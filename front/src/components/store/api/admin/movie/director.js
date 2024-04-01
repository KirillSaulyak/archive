import { createApi, fetchBaseQuery } from '../../importsCommon';
import { BASE_URL_ADMIN } from '../../../../config/links';

export const directorApi = createApi({
  reducerPath: 'directorApi',
  baseQuery: fetchBaseQuery({ baseUrl: BASE_URL_ADMIN }),
  tagTypes: ['Director'],
  endpoints: builder => (
    {
      getDirectors: builder.query({
        query: () => '/directors',
        providesTags: ['Director']
      }),
      postDirector: builder.mutation({
        query: (director) => ({
          url: '/directors',
          method: 'POST',
          body: director
        }),
        invalidatesTags: ['Director']
      }),
    }
  )
});

export const {
  useGetDirectorsQuery,
  usePostDirectorMutation,
} = directorApi;