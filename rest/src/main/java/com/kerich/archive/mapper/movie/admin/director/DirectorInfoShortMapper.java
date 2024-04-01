package com.kerich.archive.mapper.movie.admin.director;

import com.kerich.archive.dto.movie.admin.director.DirectorInfoShortDto;
import com.kerich.archive.entity.movie.Director;
import org.mapstruct.*;

@Mapper(unmappedTargetPolicy = ReportingPolicy.IGNORE)
public interface DirectorInfoShortMapper {
    Director toEntity(DirectorInfoShortDto directorInfoShortDto);

    DirectorInfoShortDto toDto(Director director);
}
