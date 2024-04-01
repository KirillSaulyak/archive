package com.kerich.archive.mapper.movie.admin.genre;

import com.kerich.archive.dto.movie.admin.genre.GenreSaveDto;
import com.kerich.archive.entity.movie.Genre;
import org.mapstruct.*;

@Mapper(unmappedTargetPolicy = ReportingPolicy.IGNORE)
public interface GenreSaveMapper {
    Genre toEntity(GenreSaveDto genreSaveDto);
}
