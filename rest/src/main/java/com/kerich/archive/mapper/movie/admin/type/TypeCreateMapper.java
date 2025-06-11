package com.kerich.archive.mapper.movie.admin.type;

import com.kerich.archive.dto.movie.admin.type.TypeCreateDto;
import com.kerich.archive.entity.movie.Type;
import org.mapstruct.*;

@Mapper(config = com.kerich.archive.config.movie.MupStructConfigDefault.class)
public interface TypeCreateMapper {
    Type toEntity(TypeCreateDto typeCreateDto);
}
