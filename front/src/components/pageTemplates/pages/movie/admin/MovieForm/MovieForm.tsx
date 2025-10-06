import Column from "@components/MUI/movie/admin/grid/columns/Column";
import RowCenter from "@components/MUI/movie/admin/grid/rows/center/RowCenter";
import SubRowCenter from "@components/MUI/movie/admin/grid/rows/center/SubRowCenter";
import DatePicker from "@components/MUI/movie/admin/datePickers/DatePicker";
import TextField from "@components/MUI/movie/admin/fields/TextField";
import NumberField from "@components/MUI/movie/admin/fields/NumberField";
import InputImage from "@components/MUI/movie/admin/inputsFile/InputImage";
import AutocompleteSingle from "@components/MUI/movie/admin/autocompletes/AutocompleteSingle";
import AutocompleteMultiple from "@components/MUI/movie/admin/autocompletes/AutocompleteMultiple";
import TextArea from "@components/MUI/movie/admin/fields/TextArea/TextArea";

import ActorCreate from "@components/pageTemplates/modalWindows/movie/actor/ActorCreate/ActorCreate";
import CountryCreate from "@components/pageTemplates/modalWindows/movie/country/CountryCreate/CountryCreate";
import DirectorCreate from "@components/pageTemplates/modalWindows/movie/director/DirectorCreate/DirectorCreate";
import GenreCreate from "@components/pageTemplates/modalWindows/movie/genre/GenreCreate/GenreCreate";
import ThemeCreate from "@components/pageTemplates/modalWindows/movie/theme/ThemeCreate/ThemeCreate";
import TranslatorCreate from "@components/pageTemplates/modalWindows/movie/translator/TranslatorCreate/TranslatorCreate";
import TypeCreate from "@components/pageTemplates/modalWindows/movie/type/TypeCreate/TypeCreate";

import { useGetActorsQuery } from "@store/api/movie/admin/actor";
import { useGetCountriesQuery } from "@store/api/movie/admin/country";
import { useGetDirectorsQuery } from "@store/api/movie/admin/director";
import { useGetGenresQuery } from "@store/api/movie/admin/genre";
import { useGetThemesQuery } from "@store/api/movie/admin/theme";
import { useGetTranslatorsQuery } from "@store/api/movie/admin/translator";
import { useGetTypesQuery } from "@store/api/movie/admin/type";

import { Props } from "./structure";

import useConvertEntityToOptionsAutocomplete from "@utils/convertEntityToOptionsAutocomplete";

import { ActorShortInfo } from "@/entitiesStructure/movie/actor";

import { useState, useEffect } from "react";

import Accordion from "@mui/material/Accordion";
import AccordionSummary from "@mui/material/AccordionSummary";
import AccordionDetails from "@mui/material/AccordionDetails";
import Typography from "@mui/material/Typography";
import ArrowDropDownIcon from "@mui/icons-material/ArrowDropDown";

import Table from "@mui/material/Table";
import TableBody from "@mui/material/TableBody";
import TableCell from "@mui/material/TableCell";
import TableContainer from "@mui/material/TableContainer";
import TableHead from "@mui/material/TableHead";
import TableRow from "@mui/material/TableRow";
import Paper from "@mui/material/Paper";

function MovieForm({ handleInputChange, oldMovieForm }: Props) {
  const { data: actors = [] } = useGetActorsQuery();
  const { data: countries = [] } = useGetCountriesQuery();
  const { data: directors = [] } = useGetDirectorsQuery();
  const { data: genres = [] } = useGetGenresQuery();
  const { data: themes = [] } = useGetThemesQuery();
  const { data: translators = [] } = useGetTranslatorsQuery();
  const { data: types = [] } = useGetTypesQuery();

  // function createData(name, calories, fat, carbs, protein) {
  //   return { name, calories, fat, carbs, protein };
  // }

  // const rows = [
  //   createData("Frozen yoghurt", 159, 6.0, 24, 4.0),
  //   createData("Ice cream sandwich", 237, 9.0, 37, 4.3),
  //   createData("Eclair", 262, 16.0, 24, 6.0),
  //   createData("Cupcake", 305, 3.7, 67, 4.3),
  //   createData("Gingerbread", 356, 16.0, 49, 3.9),
  // ];

  return (
    <>
      <RowCenter>
        {/* <Accordion>
          <AccordionSummary expandIcon={<ArrowDropDownIcon />} aria-controls="panel2-content" id="panel2-header">
            <Typography>Accordion 2</Typography>
          </AccordionSummary>
          <AccordionDetails>
            <TableContainer component={Paper}>
              <Table sx={{ minWidth: 650 }} aria-label="simple table">
                <TableBody>
                  {rows.map((row) => (
                    <TableRow key={row.name} sx={{ "&:last-child td, &:last-child th": { border: 0 } }}>
                      <TableCell component="th" scope="row">
                        {row.name}
                      </TableCell>
                      <TableCell align="right">
                        {" "}
                        <TextField label="Название" oldValue={movieForm.name} onChange={handleInputChange("name")} />
                      </TableCell>
                      <TableCell align="right">
                        {" "}
                        <TextField label="Название" oldValue={movieForm.name} onChange={handleInputChange("name")} />
                      </TableCell>
                      <TableCell align="right">
                        <DatePicker
                          label="Дата выхода"
                          oldValue={movieForm.release}
                          onChange={handleInputChange("release")}
                        />
                      </TableCell>
                    </TableRow>
                  ))}
                </TableBody>
              </Table>
            </TableContainer>
          </AccordionDetails>
        </Accordion> */}

        <Column>
          <TextField label="Название" oldValue={oldMovieForm?.name} onChange={handleInputChange("name")} />
        </Column>
        <Column>
          <TextField
            label="Иностранное название"
            oldValue={oldMovieForm?.nameAnother}
            onChange={handleInputChange("nameAnother")}
          />
        </Column>
        <Column>
          <NumberField
            label="Продолжительность"
            oldValue={oldMovieForm?.duration}
            units={"Минут"}
            onChange={handleInputChange("duration")}
          />
        </Column>
      </RowCenter>

      <RowCenter>
        <Column>
          <DatePicker label="Дата выхода" oldValue={oldMovieForm?.release} onChange={handleInputChange("release")} />
        </Column>
        <Column>
          <AutocompleteSingle
            label="Тип кино"
            oldValueId={oldMovieForm?.typeId}
            options={types}
            onChange={handleInputChange("typeId")}
          />
          <SubRowCenter>
            <Column>
              <TypeCreate />
            </Column>
          </SubRowCenter>
        </Column>
        <Column>
          <AutocompleteMultiple
            label="Страна"
            oldValueIds={oldMovieForm?.countryIds}
            options={countries}
            onChange={handleInputChange("countryIds")}
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
            label="Жанры"
            oldValueIds={oldMovieForm?.genreIds}
            options={genres}
            onChange={handleInputChange("genreIds")}
          />
          <SubRowCenter>
            <Column>
              <GenreCreate />
            </Column>
          </SubRowCenter>
        </Column>
        <Column>
          <AutocompleteSingle
            label="Переводчик"
            oldValueId={oldMovieForm?.translatorId}
            options={useConvertEntityToOptionsAutocomplete(translators, "fullName")}
            onChange={handleInputChange("translatorId")}
          />
          <SubRowCenter>
            <Column>
              <TranslatorCreate />
            </Column>
          </SubRowCenter>
        </Column>
        <Column>
          <AutocompleteMultiple
            label="Темы"
            oldValueIds={oldMovieForm?.themeIds}
            options={themes}
            onChange={handleInputChange("themeIds")}
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
            label="Режиссер"
            oldValueIds={oldMovieForm?.directorIds}
            options={useConvertEntityToOptionsAutocomplete(directors, "fullName")}
            onChange={handleInputChange("directorIds")}
          />
          <SubRowCenter>
            <Column>
              <DirectorCreate />
            </Column>
          </SubRowCenter>
        </Column>
        <Column>
          <AutocompleteMultiple
            label="Главные роли"
            oldValueIds={oldMovieForm?.actorIds}
            options={useConvertEntityToOptionsAutocomplete(actors, "fullName")}
            onChange={handleInputChange("actorIds")}
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
          <InputImage onChange={handleInputChange("poster")} />
        </Column>
      </RowCenter>

      <RowCenter>
        <Column>
          <TextArea label="Описание" oldValue={oldMovieForm?.description} onChange={handleInputChange("description")} />
        </Column>
      </RowCenter>
    </>
  );
}

export default MovieForm;
