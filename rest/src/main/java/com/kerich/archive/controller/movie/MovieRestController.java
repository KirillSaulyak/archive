package com.kerich.archive.controller.movie;

import com.kerich.archive.entity.movie.Movie;
import com.kerich.archive.service.movie.movie.MovieService;
import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequiredArgsConstructor
public class MovieRestController {
    private final MovieService movieService;

    @PostMapping
    public Movie saveMovie(Movie movie) {
        return  movieService.saveMovie(movie);
    }
}
