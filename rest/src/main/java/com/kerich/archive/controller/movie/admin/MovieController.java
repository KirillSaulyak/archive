package com.kerich.archive.controller.movie.admin;

import com.fasterxml.jackson.databind.ObjectMapper;
import com.kerich.archive.dto.movie.admin.movie.MovieCreateDto;
import com.kerich.archive.dto.movie.admin.movie.MovieInfoDto;
import com.kerich.archive.dto.movie.admin.movie.MovieUpdateDto;
import com.kerich.archive.service.movie.admin.movie.MovieService;
import com.kerich.archive.utils.fileManager.FileManager;
import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.multipart.MultipartFile;

import java.io.IOException;

@RestController
@RequiredArgsConstructor
@RequestMapping("/api/movie/admin/movies")
public class MovieController {
    private final MovieService movieService;
    private final FileManager fileManager;

    @GetMapping("/{id}")
    public MovieInfoDto getMovie(@PathVariable Long id) {
        return movieService.getMovieInfoDtoById(id);
    }

    @PostMapping
    public void createMovie(@RequestPart MultipartFile poster, @RequestPart("json") MovieCreateDto movieCreateDto) throws IOException {
        //fileManager.savePoster(poster);
        movieService.createMovie(movieCreateDto, poster);

    }

    @PutMapping
    public void updateMovie(@RequestBody MovieUpdateDto movieUpdateDto) {
        movieService.updateMovie(movieUpdateDto);
    }
}
