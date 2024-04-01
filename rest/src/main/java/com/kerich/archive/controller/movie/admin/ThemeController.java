package com.kerich.archive.controller.movie.admin;

import com.kerich.archive.dto.movie.admin.theme.ThemeSaveDto;
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
    public void saveTheme(@RequestBody ThemeSaveDto themeSaveDto) {
        themeService.saveTheme(themeSaveDto);
    }
}
