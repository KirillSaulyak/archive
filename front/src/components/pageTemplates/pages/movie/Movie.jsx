import Column from '@/components/MUI/admin/grid/columns/Column/Column';
import RowCenter from '@/components/MUI/admin/grid/rows/center/RowCenter';
import SubRowCenter from '@/components/MUI/admin/grid/rows/center/SubRowCenter';
import DatePicker from '@/components/MUI/admin/datePickers/DatePicker';
import TextField from '@/components/MUI/admin/fields/TextField';
import NumberField from '@/components/MUI/admin/fields/NumberField';
import InputImage from '@/components/MUI/admin/inputsFile/InputImage';
import AutocompleteSingle from '@/components/MUI/admin/autocompletes/AutocompleteSingle';
import AutocompleteMultiple from '@/components/MUI/admin/autocompletes/AutocompleteMultiple';
import TextArea from '@/components/MUI/admin/fields/TextArea/TextArea';

import ActorCreate from '../../modalWindows/actor/ActorCreate/ActorCreate';
import CountryCreate from '../../modalWindows/country/CountryCreate/CountryCreate';
import DirectorCreate from '../../modalWindows/director/DirectorCreate/DirectorCreate';
import GenreCreate from '../../modalWindows/genre/GenreCreate/GenreCreate';
import ThemeCreate from '../../modalWindows/theme/ThemeCreate/ThemeCreate';
import TranslatorCreate from '../../modalWindows/translator/TranslatorCreate/TranslatorCreate';
import TypeCreate from '../../modalWindows/type/TypeCreate/TypeCreate';

import { useGetActorsQuery } from '@/store/api/admin/movie/actor';
import { useGetCountriesQuery } from '@/store/api/admin/movie/country';
import { useGetDirectorsQuery } from '@/store/api/admin/movie/director';
import { useGetGenresQuery } from '@/store/api/admin/movie/genre';
import { useGetThemesQuery } from '@/store/api/admin/movie/theme';
import { useGetTranslatorsQuery } from '@/store/api/admin/movie/translator';
import { useGetTypesQuery } from '@/store/api/admin/movie/type';

import { useState, useEffect } from 'react';


function Movie({ handleInputChange, oldMovieForm }) {
    const { data: actors = [] } = useGetActorsQuery();
    const { data: countries = [] } = useGetCountriesQuery();
    const { data: directors = [] } = useGetDirectorsQuery();
    const { data: genres = [] } = useGetGenresQuery();
    const { data: themes = [] } = useGetThemesQuery();
    const { data: translators = [] } = useGetTranslatorsQuery();
    const { data: types = [] } = useGetTypesQuery();

    const [movieForm, setMovieForm] = useState({
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
        description: '',
    });

    useEffect(() => {
        if (oldMovieForm !== undefined) {
            setMovieForm({
                ...movieForm,
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

    return (
        <>
            <RowCenter>
                <Column>
                    <TextField
                        label='Название'
                        oldValue={movieForm.name}
                        onChange={handleInputChange('name')}
                    />
                </Column>
                <Column>
                    <TextField
                        label='Иностранное название'
                        oldValue={movieForm.nameAnother}
                        onChange={handleInputChange('nameAnother')}
                    />
                </Column>
                <Column>
                    <NumberField
                        label='Продолжительность'
                        oldValue={movieForm.duration}
                        units={'Минут'}
                        onChange={handleInputChange('duration')}
                    />
                </Column>
            </RowCenter>

            <RowCenter>
                <Column>
                    <DatePicker
                        label='Дата выхода'
                        oldValue={movieForm.release}
                        onChange={handleInputChange('release')}
                    />
                </Column>
                <Column>
                    <AutocompleteSingle
                        label='Тип кино'
                        valueIds={movieForm.typeId}
                        options={types}
                        optionLabel={'name'}
                        multiple={false}
                        onChange={handleInputChange('typeId')}
                    />
                    <SubRowCenter>
                        <Column>
                            <TypeCreate />
                        </Column>
                    </SubRowCenter>
                </Column>
                <Column>
                    <AutocompleteMultiple
                        label='Страна выхода'
                        valueIds={movieForm.countryIds}
                        options={countries}
                        optionLabel={'name'}
                        onChange={handleInputChange('countryIds')}
                    />
                    <SubRowCenter>
                        <Column>
                            <CountryCreate />
                        </Column>
                    </SubRowCenter>
                </Column>
            </RowCenter>

            <RowCenter>
                <Column>
                    <AutocompleteMultiple
                        label='Жанры'
                        valueIds={movieForm.genreIds}
                        options={genres}
                        optionLabel={'name'}
                        onChange={handleInputChange('genreIds')}
                    />
                    <SubRowCenter>
                        <Column>
                            <GenreCreate />
                        </Column>
                    </SubRowCenter>
                </Column>
                <Column>
                    <AutocompleteSingle
                        label='Переводчик'
                        valueIds={movieForm.translatorId}
                        options={translators}
                        optionLabel={'fullName'}
                        onChange={handleInputChange('translatorId')}
                    />
                    <SubRowCenter>
                        <Column>
                            <TranslatorCreate />
                        </Column>
                    </SubRowCenter>
                </Column>
                <Column>
                    <AutocompleteMultiple
                        label='Темы'
                        valueIds={movieForm.themeIds}
                        options={themes}
                        optionLabel={'name'}
                        onChange={handleInputChange('themeIds')}
                    />
                    <SubRowCenter>
                        <Column>
                            <ThemeCreate />
                        </Column>
                    </SubRowCenter>
                </Column>
            </RowCenter>

            <RowCenter>
                <Column>
                    <AutocompleteMultiple
                        label='Режиссер'
                        valueIds={movieForm.directorIds}
                        options={directors}
                        optionLabel={'fullName'}
                        onChange={handleInputChange('directorIds')}
                    />
                    <SubRowCenter>
                        <Column>
                            <DirectorCreate />
                        </Column>
                    </SubRowCenter>
                </Column>
                <Column>
                    <AutocompleteMultiple
                        label='Главные роли'
                        valueIds={movieForm.actorIds}
                        options={actors}
                        optionLabel={'fullName'}
                        onChange={handleInputChange('actorIds')}
                    />
                    <SubRowCenter>
                        <Column>
                            <ActorCreate />
                        </Column>
                    </SubRowCenter>
                </Column>
            </RowCenter>

            <RowCenter>
                <Column>
                    <InputImage onChange={handleInputChange('poster')} />
                </Column>
            </RowCenter>

            <RowCenter>
                <Column>
                    <TextArea
                        label='Описание'
                        oldValue={movieForm.description}
                        onChange={handleInputChange('description')}
                    />
                </Column>
            </RowCenter>
        </>
    )
}

export default Movie