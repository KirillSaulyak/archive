package com.kerich.archive.mapper.movie.admin.director;

import com.kerich.archive.dto.movie.admin.director.DirectorSaveDto;
import com.kerich.archive.entity.movie.Director;
import org.mapstruct.*;

@Mapper(unmappedTargetPolicy = ReportingPolicy.IGNORE)
public interface DirectorSaveMapper {
    Director toEntity(DirectorSaveDto directorSaveDto);
}
