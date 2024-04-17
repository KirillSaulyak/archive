import { createApi, fetchBaseQuery } from '../../importsCommon';
import { BASE_URL_ADMIN } from '../../../../config/links';

export const movieApi = createApi({
  reducerPath: 'movieApi',
  baseQuery: fetchBaseQuery({ baseUrl: BASE_URL_ADMIN }),
  endpoints: builder => (
    {
      getMovieById: builder.query({
        query: (id) => `/movies/${id}`,
      }),
      postMovie: builder.mutation({
        query: (movie) => ({   
          url: '/movies',
          method: 'POST',
          body: movie
        }),
        provideTags: ['Movie']
      }),
      putMovie: builder.mutation({
        query: (movie) => ({
          url: `/movies`,
          method: 'PUT',
          body: movie
        })
      }),
    }
  )
});

export const {
  useGetMovieByIdQuery,
  usePostMovieMutation,
  usePutMovieMutation,
} = movieApi;