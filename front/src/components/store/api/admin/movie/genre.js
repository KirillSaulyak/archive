import { createApi, fetchBaseQuery } from '../../importsCommon';
import { BASE_URL_ADMIN } from '../../../../config/links';

export const genreApi = createApi({
  reducerPath: 'genreApi',
  baseQuery: fetchBaseQuery({ baseUrl: BASE_URL_ADMIN }),
  tagTypes: ['Genres'],
  endpoints: builder => (
    {
      getGenres: builder.query({
        query: () => '/genres',
        providesTags: ['Genres']
      }),
      postGenre: builder.mutation({
        query: (genre) => ({
          url: '/genres',
          method: 'POST',
          body: genre
        }),
        invalidatesTags: ['Genres']
      }),
    }
  )
});

export const {
  useGetGenresQuery,
  usePostGenreMutation,
} = genreApi;