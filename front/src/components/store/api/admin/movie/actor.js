import { createApi, fetchBaseQuery } from '../../importsCommon';
import { BASE_URL_ADMIN } from '../../../../config/links';

export const actorApi = createApi({
  reducerPath: 'actorApi',
  baseQuery: fetchBaseQuery({ baseUrl: BASE_URL_ADMIN }),
  tagTypes: ['Actors'],
  endpoints: builder => (
    {
      getActors: builder.query({
        query: () => '/actors',
        providesTags: ['Actors']
      }),
      postActor: builder.mutation({
        query: (actor) => ({
          url: '/actors',
          method: 'POST',
          body: actor
        }),
        invalidatesTags: ['Actors']
      }),
    }
  )
});

export const {
  useGetActorsQuery,
  usePostActorMutation,
} = actorApi;