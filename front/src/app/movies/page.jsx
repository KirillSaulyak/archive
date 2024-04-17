'use client'

import Movie from '@/pageTemplates/admin/pages/movie';

import Title from '@/MUI/titels/Title';
import BackButton from "@/MUI/buttons/BackButton";
import RowCenter from '@/MUI/grids/row/center/RowCenter';
import Column from '@/MUI/grids/column/Column';
import SaveButton from '@/MUI/buttons/SaveButton';

import { usePostMovieMutation } from '@/store/api/admin/movie/movie';

import useHandleInputChange from '@/hooks/useHandleInputChange';
import useConvertFormToFormData from '@/hooks/useConvertFormToFormData';

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

                    {/* saveMovie(postMovie)} /> */}
                </Column>
            </RowCenter>
        </>
    )
}

export default Create