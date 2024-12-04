package com.kerich.archive.service.movie.admin.movie;

import com.kerich.archive.dto.movie.admin.movie.MovieCreateDto;
import com.kerich.archive.dto.movie.admin.movie.MovieInfoDto;
import com.kerich.archive.dto.movie.admin.movie.MovieUpdateDto;
import org.springframework.web.multipart.MultipartFile;


public interface MovieService {
    MovieInfoDto getMovieInfoDtoById(Long id);

    void createMovie(MovieCreateDto movieCreateDto, MultipartFile poster);

    void updateMovie(MovieUpdateDto movieUpdateDto);
}
