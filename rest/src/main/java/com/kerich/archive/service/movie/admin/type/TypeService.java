package com.kerich.archive.service.movie.admin.type;

import com.kerich.archive.dto.movie.admin.type.TypeCreateDto;
import com.kerich.archive.dto.movie.admin.type.TypeInfoShortDto;
import com.kerich.archive.entity.movie.Type;

import java.util.List;

public interface TypeService {
    void createType(TypeCreateDto typeCreateDto);

    List<TypeInfoShortDto> findAll();

    Type findTypeById(Long id);
}
