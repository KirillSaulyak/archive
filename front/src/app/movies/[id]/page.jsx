'use client'

import Title from '../../../components/MUI/titels/Title';
import BackButton from "../../../components/MUI/buttons/BackButton";

import Movie from '../../../components/pageTemplates/admin/pages/movie';

import { useGetMovieByIdQuery } from '../../../components/store/api/admin/movie/movie';
import { usePutMovieMutation } from '../../../components/store/api/admin/movie/movie';

function Update({ params }) {
    const { data: oldMovie = [] } = useGetMovieByIdQuery(params.id);
    const [putMovie] = usePutMovieMutation();

    return (
        <>
            <BackButton />
            <Title>Редактирование кино</Title>
            <Movie oldMovie={oldMovie} saveMovie={putMovie} />
        </>
    )
}

export default Update