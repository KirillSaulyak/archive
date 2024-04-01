package com.kerich.archive.service.movie.admin.theme;

import com.kerich.archive.dto.movie.admin.theme.ThemeInfoShortDto;
import com.kerich.archive.dto.movie.admin.theme.ThemeSaveDto;
import com.kerich.archive.entity.movie.Theme;

import java.util.List;

public interface ThemeService {
    void saveTheme(ThemeSaveDto themeSaveDto);

    List<ThemeInfoShortDto> findAll();

    List<Theme> findThemesByIds(List<Long> ids);
}
