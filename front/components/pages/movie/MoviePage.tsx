'use client'
import Container from "@mui/material/Container";
import Grid from '@mui/material/Unstable_Grid2';
import Row from "../../admin/grids/Row";
import SubRow from "../../admin/grids/SubRow";
import DataPicker from "../../admin/dataPickers/DataPicker";
import TextField from "../../admin/textFields/TextField";
import Dialog from "../../admin/dialogs/Dialog";
import InputImage from "../../admin/inputsFile/InputImage";
import Autocomplete from "../../admin/autocompletes/Autocomplete";
import TextArea from "../../admin/textFields/TextArea";
import SaveButton from "../../admin/buttons/SaveButton";
import TitleWithBackButton from "../../admin/titels/TitleWithBackButton";

export default function MoviePage() {

    return (
        <main>
            <Container>
                <TitleWithBackButton>Добавление кино</TitleWithBackButton>
                <Row>
                    <Grid>
                        <TextField label="Название" />
                    </Grid>
                    <Grid>
                        <TextField label="Иностранное название" />
                    </Grid>
                    <Grid>
                        <TextField label="Продолжительность" />
                    </Grid>
                </Row>

                <Row>
                    <Grid>
                        <DataPicker />
                    </Grid>
                    <Grid>
                        <Autocomplete label="Тип кино" options={["Аниме", "Фильмы", "Сериалы"]} />
                        <SubRow>
                            <Grid>
                                <Dialog labelButton="Добавить тип" content="Новый тип" title="Добавить новый тип кино" />
                            </Grid>
                        </SubRow>
                    </Grid>
                    <Grid>
                        <Autocomplete label="Страна выхода" options={["Украина", "США", "Индия"]} />
                        <SubRow>
                            <Grid>
                                <Dialog labelButton="Добавить страну" content="Новая страна" title="Добавить новую страну" />
                            </Grid>
                        </SubRow>
                    </Grid>
                </Row>

                <Row>
                    <Grid>
                        <Autocomplete label="Жанры" options={["Романтическое", "Комедия", "Ужасы"]} />
                        <SubRow>
                            <Grid>
                                <Dialog labelButton="Добавить жанр" content="Новый жанр" title="Добавить новый жанр" />
                            </Grid>
                        </SubRow>
                    </Grid>
                    <Grid>
                        <Autocomplete label="Переводчик" options={["Anilibria", "Jam", "Bund"]} />
                        <SubRow>
                            <Grid>
                                <Dialog labelButton="Добавить переводчика" content="Новый переводчик" title="Добавить нового переводчика" />
                            </Grid>
                        </SubRow>
                    </Grid>
                    <Grid>
                        <Autocomplete label="Темы" options={["Пираты", "Военное", "фильмы FOX"]} />
                        <SubRow>
                            <Grid>
                                <Dialog labelButton="Добавить тему" content="Новая тема" title="Добавить новую тему" />
                            </Grid>
                        </SubRow>
                    </Grid>
                </Row>

                <Row>
                    <Grid>
                        <Autocomplete label="Режиссер" options={["Брэдли Букер", "Дэвид Гроссман", "Адам Бернштейн"]} />
                        <SubRow>
                            <Grid>
                                <Dialog labelButton="Добавить режиссера" content="Новый режиссер" title="Добавить нового режиссера" />
                            </Grid>
                        </SubRow>
                    </Grid>
                    <Grid>
                        <Autocomplete label="Главные роли" options={["Андриано Челентано", "Джекки Чан", "Илон Маск"]} />
                        <SubRow>
                            <Grid>
                                <Dialog labelButton="Добавить актера" content="Новый актер" title="Добавить нового актера" />
                            </Grid>
                        </SubRow>
                    </Grid>
                </Row>

                <Row>
                    <Grid>
                        <InputImage />
                    </Grid>
                </Row>

                <Row>
                    <Grid>
                        <TextArea label="Описание" />
                    </Grid>
                </Row>

                <Row>
                    <Grid>
                        <SaveButton />
                    </Grid>
                </Row>
            </Container>
        </main>
    )
}