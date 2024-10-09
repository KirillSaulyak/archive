package com.kerich.archive.controller.movie.admin;

import com.kerich.archive.dto.movie.admin.genre.GenreCreateDto;
import com.kerich.archive.dto.movie.admin.genre.GenreInfoShortDto;
import com.kerich.archive.service.movie.admin.genre.GenreService;
import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequiredArgsConstructor
@RequestMapping("/api/movie/admin/genres")
public class GenreController {
    private final GenreService genreService;
    @GetMapping
    public List<GenreInfoShortDto> getGenres() {
        return genreService.findAll();
    }

    @PostMapping
    public void createGenre(@RequestBody GenreCreateDto genreCreateDto) {
        genreService.createGenre(genreCreateDto);
    }
}
