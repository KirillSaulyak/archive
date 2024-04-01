import Column from '../../../MUI/grids/column/Column';
import RowCenter from '../../../MUI/grids/row/center/RowCenter';
import SubRowCenter from '../../../MUI/grids/row/center/SubRowCenter';
import DatePicker from '../../../MUI/dataPickers/DataPicker';
import TextField from '../../../MUI/textFields/TextField';
import InputImage from '../../../MUI/inputsFile/InputImage';
import Autocomplete from '../../../MUI/autocompletes/Autocomplete';
import TextArea from '../../../MUI/textFields/TextArea';
import SaveButton from '../../../MUI/buttons/SaveButton';

import ActorCreate from '../modalWindows/actorCreate';
import CountryCreate from '../modalWindows/countryCreate';
import DirectorCreate from '../modalWindows/directorCreate';
import GenreCreate from '../modalWindows/genreCreate';
import ThemeCreate from '../modalWindows/themeCreate';
import TranslatorCreate from '../modalWindows/translatorCreate';
import TypeCreate from '../modalWindows/typeCreate';

import { useGetActorsQuery } from '../../../store/api/admin/movie/actor';
import { useGetCountriesQuery } from '../../../store/api/admin/movie/country';
import { useGetDirectorsQuery } from '../../../store/api/admin/movie/director';
import { useGetGenresQuery } from '../../../store/api/admin/movie/genre';
import { useGetThemesQuery } from '../../../store/api/admin/movie/theme';
import { useGetTranslatorsQuery } from '../../../store/api/admin/movie/translator';
import { useGetTypesQuery } from '../../../store/api/admin/movie/type';

import { useState, useEffect } from '../commonImports';
import useHandleInputChange from '../../../hooks/useHandleInputChange';

function Movie({ oldMovie, saveMovie }) {
    const { data: actors = [] } = useGetActorsQuery();
    const { data: countries = [] } = useGetCountriesQuery();
    const { data: directors = [] } = useGetDirectorsQuery();
    const { data: genres = [] } = useGetGenresQuery();
    const { data: themes = [] } = useGetThemesQuery();
    const { data: translators = [] } = useGetTranslatorsQuery();
    const { data: types = [] } = useGetTypesQuery();

    const [movieForm, setMovieForm] = useState({
        id: null,
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

    const { handleInputChange } = useHandleInputChange(movieForm, setMovieForm);

    useEffect(() => {
        if (oldMovie !== undefined) {
            setMovieForm({
                ...movieForm,
                id: oldMovie.id,
                name: oldMovie.name,
                nameAnother: oldMovie.nameAnother,
                duration: oldMovie.duration,
                release: oldMovie.release,
                typeId: oldMovie.typeId,
                countryIds: oldMovie.countryIds,
                genreIds: oldMovie.genreIds,
                translatorId: oldMovie.translatorId,
                themeIds: oldMovie.themeIds,
                actorIds: oldMovie.actorIds,
                directorIds: oldMovie.directorIds,
                description: oldMovie.description,
            })
        }
    }, [oldMovie]);

    return (
        <>
            <RowCenter>
                <Column>
                    <TextField
                        label='Название'
                        value={movieForm.name}
                        onChange={handleInputChange('name')}
                    />
                </Column>
                <Column>
                    <TextField
                        label='Иностранное название'
                        value={movieForm.nameAnother}
                        onChange={handleInputChange('nameAnother')}
                    />
                </Column>
                <Column>
                    <TextField
                        label='Продолжительность'
                        isNumber={true}
                        value={movieForm.duration}
                        onChange={handleInputChange('duration')}
                    />
                </Column>
            </RowCenter>

            <RowCenter>
                <Column>
                    <DatePicker
                        label='Дата выхода'
                        value={movieForm.release}
                        onChange={handleInputChange('release')}
                    />
                </Column>
                <Column>
                    <Autocomplete
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
                    <Autocomplete
                        label='Страна выхода'
                        valueIds={movieForm.countryIds}
                        options={countries}
                        optionLabel={'name'}
                        multiple={true}
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
                    <Autocomplete
                        label='Жанры'
                        valueIds={movieForm.genreIds}
                        options={genres}
                        optionLabel={'name'}
                        multiple={true}
                        onChange={handleInputChange('genreIds')}
                    />
                    <SubRowCenter>
                        <Column>
                            <GenreCreate />
                        </Column>
                    </SubRowCenter>
                </Column>
                <Column>
                    <Autocomplete
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
                    <Autocomplete
                        label='Темы'
                        valueIds={movieForm.themeIds}
                        options={themes}
                        optionLabel={'name'}
                        multiple={true}
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
                    <Autocomplete
                        label='Режиссер'
                        valueIds={movieForm.directorIds}
                        options={directors}
                        optionLabel={'fullName'}
                        multiple={true}
                        onChange={handleInputChange('directorIds')}
                    />
                    <SubRowCenter>
                        <Column>
                            <DirectorCreate />
                        </Column>
                    </SubRowCenter>
                </Column>
                <Column>
                    <Autocomplete
                        label='Главные роли'
                        valueIds={movieForm.actorIds}
                        options={actors}
                        optionLabel={'fullName'}
                        multiple={true}
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
                    <InputImage />
                </Column>
            </RowCenter>

            <RowCenter>
                <Column>
                    <TextArea
                        label='Описание'
                        value={movieForm.description}
                        onChange={handleInputChange('description')}
                    />
                </Column>
            </RowCenter>

            <RowCenter>
                <Column>
                    <SaveButton onClick={() => saveMovie(movieForm)} />
                </Column>
            </RowCenter>
        </>
    )
}

export default Movie