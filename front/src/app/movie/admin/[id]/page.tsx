"use client";

import Title from "@components/MUI/movie/admin/titels/Title";
import BackButton from "@components/MUI/movie/admin/buttons/BackButton";
import RowCenter from "@components/MUI/movie/admin/grid/rows/center/RowCenter";
import Column from "@components/MUI/movie/admin/grid/columns/Column";
import SaveButton from "@components/MUI/movie/admin/buttons/SaveButton";

import MovieForm from "@/components/pageTemplates/pages/movie/admin/MovieForm";

import { useGetMovieByIdQuery, usePutMovieMutation } from "@store/api/movie/admin/movie";

import handleInputChange from "@/utils/handleInputChange";
import convertFormToFormData from "@/utils/convertFormToFormData";

import { MovieUpdateForm } from "@entitiesStructure/movie/movie";

import { useEffect, useState } from "react";

import { useParams } from "next/navigation";

function Update() {
  const { id: movieId }: { id?: string } = useParams();

  const { data: oldMovieForm } = useGetMovieByIdQuery(
    movieId ||
      (() => {
        throw new Error("Movie ID is missing!");
      })()
  );
  const [putMovie] = usePutMovieMutation();

  const [movieUpdateForm, setMovieUpdateForm] = useState<MovieUpdateForm>({
    id: "",
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
    poster: "",
    description: "",
  });

  useEffect(() => {
    if (oldMovieForm) {
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
        poster: oldMovieForm.poster,
        description: oldMovieForm.description,
      });
    }
  }, [oldMovieForm]);

  const saveMovie = () => {
    const formData = convertFormToFormData(movieUpdateForm, ["poster"]);
    putMovie(formData);
  };

  return (
    <>
      <BackButton />
      <Title>Редактирование кино</Title>
      <MovieForm oldMovieForm={oldMovieForm} handleInputChange={handleInputChange(setMovieUpdateForm)} />
      <RowCenter>
        <Column>
          <SaveButton onClick={saveMovie} />
        </Column>
      </RowCenter>
    </>
  );
}

export default Update;
