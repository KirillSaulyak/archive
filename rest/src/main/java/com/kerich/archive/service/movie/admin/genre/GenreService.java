package com.kerich.archive.service.movie.admin.genre;

import com.kerich.archive.dto.movie.admin.genre.GenreInfoShortDto;
import com.kerich.archive.dto.movie.admin.genre.GenreCreateDto;
import com.kerich.archive.entity.movie.Genre;

import java.util.List;

public interface GenreService {
    void createGenre(GenreCreateDto genreCreateDto);

    List<GenreInfoShortDto> findAll();

    List<Genre> findGenresByIds(List<Long> ids);
}
