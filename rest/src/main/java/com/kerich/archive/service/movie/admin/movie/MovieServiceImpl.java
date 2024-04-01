package com.kerich.archive.service.movie.admin.movie;

import com.kerich.archive.dto.movie.admin.movie.MovieInfoDto;
import com.kerich.archive.dto.movie.admin.movie.MovieSaveDto;
import com.kerich.archive.dto.movie.admin.movie.MovieUpdateDto;
import com.kerich.archive.entity.movie.Movie;
import com.kerich.archive.mapper.movie.admin.movie.MovieInfoMapper;
import com.kerich.archive.mapper.movie.admin.movie.MovieSaveMapper;
import com.kerich.archive.mapper.movie.admin.movie.MovieUpdateMapper;
import com.kerich.archive.repository.movie.MovieRepository;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.NoSuchElementException;

@Service
@RequiredArgsConstructor
public class MovieServiceImpl implements MovieService {
    private final MovieRepository movieRepository;
    private final MovieInfoMapper movieInfoMapper;
    private final MovieSaveMapper movieSaveMapper;
    private final MovieUpdateMapper movieUpdateMapper;

    @Override
    public MovieInfoDto getMovieInfoDtoById(Long id) {
        return movieInfoMapper.toDto(movieRepository.findById(id).orElseThrow(() -> new NoSuchElementException("Wrong movie id")));
    }

    @Override
    @Transactional
    public void saveMovie(MovieSaveDto movieSaveDto) {
        Movie movie = movieSaveMapper.toEntity(movieSaveDto);
        movie.setPathToPoster("TEMP NOTHING");
        movieRepository.save(movie);
    }

    @Override
    @Transactional
    public void updateMovie(MovieUpdateDto movieUpdateDto) {
        Movie movie = movieRepository.findById(movieUpdateDto.id()).orElseThrow(() -> new NoSuchElementException("Wrong movie id"));
        movieUpdateMapper.updateMovieFromDto(movie, movieUpdateDto);
    }
}
