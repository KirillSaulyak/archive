package com.kerich.archive.controller.movie.admin;

import com.kerich.archive.dto.movie.admin.movie.MovieCreateDto;
import com.kerich.archive.dto.movie.admin.movie.MovieInfoDto;
import com.kerich.archive.dto.movie.admin.movie.MovieUpdateDto;
import com.kerich.archive.service.movie.admin.movie.MovieService;
import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.multipart.MultipartFile;

@RestController
@RequiredArgsConstructor
@RequestMapping("/api/movie/admin/movies")
public class MovieController {
    private final MovieService movieService;

    @GetMapping("/{id}")
    public MovieInfoDto getMovie(@PathVariable Long id) {
        return movieService.getMovieInfoDtoById(id);
    }

    @PostMapping
    public void createMovie(@RequestPart MultipartFile poster, @RequestPart("json") MovieCreateDto movieCreateDto) {
        System.out.println("sdf");

        //movieService.saveMovie(movieSaveDto);
    }

    @PutMapping
    public void updateMovie(@RequestBody MovieUpdateDto movieUpdateDto) {
        movieService.updateMovie(movieUpdateDto);
    }
}
