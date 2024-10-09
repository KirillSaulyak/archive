package com.kerich.archive.controller.movie.admin;

import com.kerich.archive.dto.movie.admin.theme.ThemeCreateDto;
import com.kerich.archive.dto.movie.admin.theme.ThemeInfoShortDto;
import com.kerich.archive.service.movie.admin.theme.ThemeService;
import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequiredArgsConstructor
@RequestMapping("/api/movie/admin/themes")
public class ThemeController {
    private final ThemeService themeService;

    @GetMapping
    public List<ThemeInfoShortDto> getThemes() {
        return themeService.findAll();
    }

    @PostMapping
    public void createTheme(@RequestBody ThemeCreateDto themeCreateDto) {
        themeService.createTheme(themeCreateDto);
    }
}
