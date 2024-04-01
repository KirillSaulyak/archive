package com.kerich.archive.mapper.movie.admin.type;

import com.kerich.archive.dto.movie.admin.type.TypeSaveDto;
import com.kerich.archive.entity.movie.Type;
import org.mapstruct.*;

@Mapper(unmappedTargetPolicy = ReportingPolicy.IGNORE)
public interface TypeSaveMapper {
    Type toEntity(TypeSaveDto typeSaveDto);
}
