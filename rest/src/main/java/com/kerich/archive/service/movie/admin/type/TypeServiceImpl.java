package com.kerich.archive.service.movie.admin.type;

import com.kerich.archive.dto.movie.admin.type.TypeCreateDto;
import com.kerich.archive.dto.movie.admin.type.TypeInfoShortDto;
import com.kerich.archive.entity.movie.Type;
import com.kerich.archive.mapper.movie.admin.type.TypeCreateMapper;
import com.kerich.archive.mapper.movie.admin.type.TypeInfoShortMapper;
import com.kerich.archive.repository.movie.TypeRepository;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.NoSuchElementException;
import java.util.stream.Collectors;

@Service
@RequiredArgsConstructor
public class TypeServiceImpl implements TypeService {
    private final TypeRepository typeRepository;
    private final TypeInfoShortMapper typeInfoShortMapper;
    private final TypeCreateMapper typeCreateMapper;

    @Override
    public void createType(TypeCreateDto typeCreateDto) {
        typeRepository.save(typeCreateMapper.toEntity(typeCreateDto));
    }

    @Override
    public List<TypeInfoShortDto> findAll() {
        return typeRepository.findAll().stream().map(typeInfoShortMapper::toDto).collect(Collectors.toList());
    }

    @Override
    public Type findTypeById(Long id) {
        return typeRepository.findTypeById(id).orElseThrow(() -> new NoSuchElementException("Wrong type id"));
    }
}
