package com.kerich.archive.controller.movie.admin;

import com.kerich.archive.dto.movie.admin.movie.MovieInfoDto;
import com.kerich.archive.dto.movie.admin.movie.MovieSaveDto;
import com.kerich.archive.dto.movie.admin.movie.MovieUpdateDto;
import com.kerich.archive.service.movie.admin.movie.MovieService;
import lombok.RequiredArgsConstructor;
import org.springframework.http.MediaType;
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

    @PostMapping(consumes = { MediaType.MULTIPART_FORM_DATA_VALUE })
    public void saveMovie(@RequestPart(name = "files", required = false) MultipartFile poster, @RequestPart(name = "json", required = false) MovieSaveDto movieSaveDto) {
        System.out.println("sdf");

        //movieService.saveMovie(movieSaveDto);
    }

    @PutMapping
    public void updateMovie(@RequestBody MovieUpdateDto movieUpdateDto) {
        movieService.updateMovie(movieUpdateDto);
    }
}
