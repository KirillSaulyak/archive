package com.kerich.archive.mapper.movie.admin.genre;

import com.kerich.archive.dto.movie.admin.genre.GenreInfoShortDto;
import com.kerich.archive.entity.movie.Genre;
import org.mapstruct.*;

@Mapper(unmappedTargetPolicy = ReportingPolicy.IGNORE)
public interface GenreInfoShortMapper {
    Genre toEntity(GenreInfoShortDto genreInfoShortDto);

    GenreInfoShortDto toDto(Genre genre);
}
