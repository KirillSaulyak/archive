package com.kerich.archive.service.movie.admin.theme;

import com.kerich.archive.dto.movie.admin.theme.ThemeCreateDto;
import com.kerich.archive.dto.movie.admin.theme.ThemeInfoShortDto;
import com.kerich.archive.entity.movie.Theme;

import java.util.List;

public interface ThemeService {
    void createTheme(ThemeCreateDto themeCreateDto);

    List<ThemeInfoShortDto> findAll();

    List<Theme> findThemesByIds(List<Long> ids);
}
