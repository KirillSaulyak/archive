package com.kerich.archive.service.movie.admin.movie;

import com.kerich.archive.dto.movie.admin.movie.MovieInfoDto;
import com.kerich.archive.dto.movie.admin.movie.MovieSaveDto;
import com.kerich.archive.dto.movie.admin.movie.MovieUpdateDto;


public interface MovieService {
    MovieInfoDto getMovieInfoDtoById(Long id);

    void saveMovie(MovieSaveDto movieSaveDto);

    void updateMovie(MovieUpdateDto movieUpdateDto);
}
