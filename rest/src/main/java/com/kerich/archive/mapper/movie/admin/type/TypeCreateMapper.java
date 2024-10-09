package com.kerich.archive.mapper.movie.admin.type;

import com.kerich.archive.dto.movie.admin.type.TypeCreateDto;
import com.kerich.archive.entity.movie.Type;
import org.mapstruct.*;

@Mapper(unmappedTargetPolicy = ReportingPolicy.IGNORE)
public interface TypeCreateMapper {
    Type toEntity(TypeCreateDto typeCreateDto);
}
