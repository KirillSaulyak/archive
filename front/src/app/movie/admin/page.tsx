"use client";

import MovieForm from "@/components/pageTemplates/pages/movie/admin/MovieForm";

import BackButton from "@components/MUI/movie/admin/buttons/BackButton";
import SaveButton from "@components/MUI/movie/admin/buttons/SaveButton";
import Column from "@components/MUI/movie/admin/grid/columns/Column/Column";
import RowCenter from "@components/MUI/movie/admin/grid/rows/center/RowCenter";
import Title from "@components/MUI/movie/admin/titels/Title/Title";

import { usePostMovieMutation } from "@store/api/movie/admin/movie";

import convertFormToFormData from "@/utils/convertFormToFormData";
import handleInputChange from "@/utils/handleInputChange";

import { useState } from "react";

import { MovieCreateForm } from "@entitiesStructure/movie/movie";

import Menu from "@mui/material/Menu";
import MenuItem from "@mui/material/MenuItem";
import Button from "@mui/material/Button";
import Grid from "@mui/material/Grid";
import React from "react";

function Create() {
  // const [anchorEl, setAnchorEl] = React.useState(null);
  // const handleClick = (event) => {
  //   setAnchorEl(event.currentTarget);
  // };
  // const handleClose = () => {
  //   setAnchorEl(null);
  // };

  const [postMovie] = usePostMovieMutation();
  const [movieCreateForm, setMovieCreateForm] = useState<MovieCreateForm>({
    name: "",
    nameAnother: "",
    duration: 0,
    release: new Date(),
    typeId: "",
    countryIds: [],
    genreIds: [],
    translatorId: "",
    themeIds: [],
    actorIds: [],
    directorIds: [],
    poster: null,
    description: "",
  });

  const saveMovie = () => {
    const formData = convertFormToFormData(movieCreateForm, ["poster"]);
    postMovie(formData);
  };

  return (
    <>
      {/* <div>
        <Button aria-controls="simple-menu" aria-haspopup="true" onClick={handleClick}>
          Открыть меню
        </Button>
        <Menu id="simple-menu" anchorEl={anchorEl} keepMounted open={Boolean(anchorEl)} onClose={handleClose}>
          <Grid container>
            <Grid item xs={6}>
              <MenuItem onClick={handleClose}>Элемент 1</MenuItem>
              <MenuItem onClick={handleClose}>Элемент 2</MenuItem>
              <MenuItem onClick={handleClose}>Элемент 3</MenuItem>
            </Grid>
            <Grid item xs={6}>
              <MenuItem onClick={handleClose}>Элемент 4</MenuItem>
              <MenuItem onClick={handleClose}>Элемент 5</MenuItem>
              <MenuItem onClick={handleClose}>Элемент 6</MenuItem>
            </Grid>
          </Grid>
        </Menu>
      </div> */}
      <BackButton />
      <Title>Добавление кино</Title>
      <MovieForm handleInputChange={handleInputChange(setMovieCreateForm)} />
      <RowCenter>
        <Column>
          <SaveButton onClick={() => saveMovie()} />
        </Column>
      </RowCenter>
    </>
  );
}

export default Create;
