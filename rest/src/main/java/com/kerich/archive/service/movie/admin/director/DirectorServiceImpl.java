package com.kerich.archive.service.movie.admin.director;

import com.kerich.archive.dto.movie.admin.director.DirectorSaveDto;
import com.kerich.archive.dto.movie.admin.director.DirectorInfoShortDto;
import com.kerich.archive.entity.movie.Director;
import com.kerich.archive.mapper.movie.admin.director.DirectorSaveMapper;
import com.kerich.archive.mapper.movie.admin.director.DirectorInfoShortMapper;
import com.kerich.archive.repository.movie.DirectorRepository;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
@RequiredArgsConstructor
public class DirectorServiceImpl implements DirectorService {
    private final DirectorRepository directorRepository;
    private final DirectorInfoShortMapper directorInfoShortMapper;
    private final DirectorSaveMapper directorSaveMapper;

    @Override
    public void saveDirector(DirectorSaveDto directorSaveDto) {
        directorRepository.save(directorSaveMapper.toEntity(directorSaveDto));
    }

    @Override
    public List<DirectorInfoShortDto> findAll() {
        return directorRepository.findAll().stream().map(directorInfoShortMapper::toDto).collect(Collectors.toList());
    }

    @Override
    public List<Director> findDirectorsByIds(List<Long> ids) {
        return directorRepository.findDirectorByIdIn(ids);
    }
}
