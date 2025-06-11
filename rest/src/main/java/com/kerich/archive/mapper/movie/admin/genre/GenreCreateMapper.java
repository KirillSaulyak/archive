package com.kerich.archive.mapper.movie.admin.genre;

import com.kerich.archive.dto.movie.admin.genre.GenreCreateDto;
import com.kerich.archive.entity.movie.Genre;
import org.mapstruct.*;

@Mapper(config = com.kerich.archive.config.movie.MupStructConfigDefault.class)
public interface GenreCreateMapper {
    Genre toEntity(GenreCreateDto genreCreateDto);
}
