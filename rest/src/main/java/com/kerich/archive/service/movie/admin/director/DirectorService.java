package com.kerich.archive.service.movie.admin.director;

import com.kerich.archive.dto.movie.admin.director.DirectorInfoShortDto;
import com.kerich.archive.dto.movie.admin.director.DirectorCreateDto;
import com.kerich.archive.entity.movie.Director;

import java.util.List;

public interface DirectorService {
    void createDirector(DirectorCreateDto directorCreateDto);

    List<DirectorInfoShortDto> findAll();

    List<Director> findDirectorsByIds(List<Long> ids);
}
