package com.kerich.archive.mapper.movie.admin.type;

import com.kerich.archive.dto.movie.admin.type.TypeInfoShortDto;
import com.kerich.archive.entity.movie.Type;
import org.mapstruct.*;

@Mapper(unmappedTargetPolicy = ReportingPolicy.IGNORE)
public interface TypeInfoShortMapper {
    Type toEntity(TypeInfoShortDto typeInfoShortDto);

    TypeInfoShortDto toDto(Type type);
}
