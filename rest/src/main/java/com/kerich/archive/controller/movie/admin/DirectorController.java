package com.kerich.archive.controller.movie.admin;

import com.kerich.archive.dto.movie.admin.director.DirectorCreateDto;
import com.kerich.archive.dto.movie.admin.director.DirectorInfoShortDto;
import com.kerich.archive.service.movie.admin.director.DirectorService;
import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequiredArgsConstructor
@RequestMapping("/api/movie/admin/directors")
public class DirectorController {
    private final DirectorService directorService;

    @GetMapping
    public List<DirectorInfoShortDto> getDirectors() {
        return directorService.findAll();
    }

    @PostMapping
    public void createDirector(@RequestBody DirectorCreateDto directorCreateDto) {
        directorService.createDirector(directorCreateDto);
    }
}
