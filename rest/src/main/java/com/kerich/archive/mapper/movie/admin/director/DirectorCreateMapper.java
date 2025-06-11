package com.kerich.archive.mapper.movie.admin.director;

import com.kerich.archive.dto.movie.admin.director.DirectorCreateDto;
import com.kerich.archive.entity.movie.Director;
import org.mapstruct.*;

@Mapper(config = com.kerich.archive.config.movie.MupStructConfigDefault.class)
public interface DirectorCreateMapper {
    Director toEntity(DirectorCreateDto directorCreateDto);
}
