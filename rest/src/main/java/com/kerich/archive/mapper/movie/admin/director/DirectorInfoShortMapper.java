package com.kerich.archive.mapper.movie.admin.director;

import com.kerich.archive.dto.movie.admin.director.DirectorInfoShortDto;
import com.kerich.archive.entity.movie.Director;
import org.mapstruct.*;

@Mapper(config = com.kerich.archive.config.movie.MupStructConfigDefault.class)
public interface DirectorInfoShortMapper {
    Director toEntity(DirectorInfoShortDto directorInfoShortDto);

    DirectorInfoShortDto toDto(Director director);
}
