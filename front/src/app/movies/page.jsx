'use client'

import Movie from '@/pageTemplates/pages/movie';

import BackButton from "@/MUI/admin/buttons/BackButton";
import SaveButton from '@/MUI/admin/buttons/SaveButton';
import Column from '@/MUI/admin/grid/columns/Column/Column';
import RowCenter from '@/MUI/admin/grid/rows/center/RowCenter';
import Title from '@/MUI/admin/titels/Title/Title';

import { usePostMovieMutation } from '@/store/api/admin/movie/movie';

import useConvertFormToFormData from '../../hooks/useConvertFormToFormData';
import useHandleInputChange from '../../hooks/useHandleInputChange';

import { useState } from 'react';

function Create() {
    const [postMovie] = usePostMovieMutation();
    const [movieCreateForm, setMovieCreateForm] = useState({
        name: '',
        nameAnother: '',
        duration: '',
        release: new Date(),
        typeId: null,
        countryIds: [],
        genreIds: [],
        translatorId: null,
        themeIds: [],
        actorIds: [],
        directorIds: [],
        poster: null,
        description: '',
    });

    const { handleInputChange } = useHandleInputChange(movieCreateForm, setMovieCreateForm);

    const saveMovie = () => {
        const formData = useConvertFormToFormData(movieCreateForm, ['poster']);
        postMovie(formData);
    }

    return (
        <>
            <BackButton />
            <Title>Добавление кино</Title>
            <Movie handleInputChange={handleInputChange} />
            <RowCenter>
                <Column>
                    <SaveButton onClick={() => saveMovie()} />
                </Column>
            </RowCenter>
        </>
    )
}

export default Create