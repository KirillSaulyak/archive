'use client'

import Movie from '../../components/pageTemplates/admin/pages/movie';

import Title from '../../components/MUI/titels/Title';
import BackButton from "../../components/MUI/buttons/BackButton";

import { usePostMovieMutation } from '../../components/store/api/admin/movie/movie';

function Create() {
    const [postMovie] = usePostMovieMutation();

    return (
        <>
            <BackButton />
            <Title>Добавление кино</Title>
            <Movie saveMovie={postMovie} />
        </>
    )
}

export default Create