package com.kerich.archive.service.movie.admin.genre;

import com.kerich.archive.dto.movie.admin.genre.GenreCreateDto;
import com.kerich.archive.dto.movie.admin.genre.GenreInfoShortDto;
import com.kerich.archive.entity.movie.Genre;
import com.kerich.archive.mapper.movie.admin.genre.GenreCreateMapper;
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
    private final GenreCreateMapper genreCreateMapper;

    @Override
    public void createGenre(GenreCreateDto genreCreateDto) {
        genreRepository.save(genreCreateMapper.toEntity(genreCreateDto));
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
