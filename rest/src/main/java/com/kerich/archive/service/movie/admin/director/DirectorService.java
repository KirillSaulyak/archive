package com.kerich.archive.service.movie.admin.director;

import com.kerich.archive.dto.movie.admin.director.DirectorInfoShortDto;
import com.kerich.archive.dto.movie.admin.director.DirectorSaveDto;
import com.kerich.archive.entity.movie.Director;

import java.util.List;

public interface DirectorService {
    void saveDirector(DirectorSaveDto directorSaveDto);

    List<DirectorInfoShortDto> findAll();

    List<Director> findDirectorsByIds(List<Long> ids);
}
