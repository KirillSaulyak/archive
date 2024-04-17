'use client'

import Title from '@/MUI/titels/Title';
import BackButton from "@/MUI/buttons/BackButton";
import RowCenter from '@/MUI/grids/row/center/RowCenter';
import Column from '@/MUI/grids/column/Column';
import SaveButton from '@/MUI/buttons/SaveButton';

import Movie from '@/pageTemplates/admin/pages/movie';

import { useGetMovieByIdQuery, usePutMovieMutation } from '@/store/api/admin/movie/movie';

import useHandleInputChange from '@/hooks/useHandleInputChange';

import { useEffect, useState } from 'react'; //подумать как сделать общие испорты

function Update({ params }) {
    const { data: oldMovieForm = [] } = useGetMovieByIdQuery(params.id);
    const [putMovie] = usePutMovieMutation();

    const [movieUpdateForm, setMovieUpdateForm] = useState({
        id: '',
        name: '',
        nameAnother: '',
        duration: '',
        release: new Date(),
        typeId: '',
        countryIds: [],
        genreIds: [],
        translatorId: '',
        themeIds: [],
        actorIds: [],
        directorIds: [],
        description: '',
    });

    const { handleInputChange } = useHandleInputChange(movieUpdateForm, setMovieUpdateForm);

    useEffect(() => {
        if (oldMovieForm !== undefined) {
            setMovieUpdateForm({
                ...movieUpdateForm,
                id: oldMovieForm.id,
                name: oldMovieForm.name,
                nameAnother: oldMovieForm.nameAnother,
                duration: oldMovieForm.duration,
                release: oldMovieForm.release,
                typeId: oldMovieForm.typeId,
                countryIds: oldMovieForm.countryIds,
                genreIds: oldMovieForm.genreIds,
                translatorId: oldMovieForm.translatorId,
                themeIds: oldMovieForm.themeIds,
                actorIds: oldMovieForm.actorIds,
                directorIds: oldMovieForm.directorIds,
                description: oldMovieForm.description,
            })
        }
    }, [oldMovieForm]);

    const saveMovie = () => {
        putMovie(movieUpdateForm);
    }

    return (
        <>
            <BackButton />
            <Title>Редактирование кино</Title>
            <Movie oldMovieForm={oldMovieForm} handleInputChange={handleInputChange} />
            <RowCenter>
                <Column>
                    <SaveButton onClick={saveMovie} />
                </Column>
            </RowCenter>
        </>
    )
}

export default Update