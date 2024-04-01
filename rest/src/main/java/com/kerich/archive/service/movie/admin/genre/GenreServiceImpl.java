package com.kerich.archive.service.movie.admin.genre;

import com.kerich.archive.dto.movie.admin.genre.GenreSaveDto;
import com.kerich.archive.dto.movie.admin.genre.GenreInfoShortDto;
import com.kerich.archive.entity.movie.Genre;
import com.kerich.archive.mapper.movie.admin.genre.GenreSaveMapper;
import com.kerich.archive.mapper.movie.admin.genre.GenreInfoShortMapper;
import com.kerich.archive.repository.movie.GenreRepository;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
@RequiredArgsConstructor
public class GenreServiceImpl implements GenreService {
    private final GenreRepository genreRepository;
    private final GenreInfoShortMapper genreInfoShortMapper;
    private final GenreSaveMapper genreSaveMapper;

    @Override
    public void saveGenre(GenreSaveDto genreSaveDto) {
        genreRepository.save(genreSaveMapper.toEntity(genreSaveDto));
    }

    @Override
    public List<GenreInfoShortDto> findAll() {
        return genreRepository.findAll().stream().map(genreInfoShortMapper::toDto).collect(Collectors.toList());
    }

    @Override
    public List<Genre> findGenresByIds(List<Long> ids) {
        return genreRepository.findGenreByIdIn(ids);
    }
}
