package com.kerich.archive.service.movie.admin.type;

import com.kerich.archive.dto.movie.admin.type.TypeInfoShortDto;
import com.kerich.archive.dto.movie.admin.type.TypeSaveDto;
import com.kerich.archive.entity.movie.Type;

import java.util.List;

public interface TypeService {
    void saveType(TypeSaveDto typeSaveDto);

    List<TypeInfoShortDto> findAll();

    Type findTypeById(Long id);
}
