package com.kerich.archive.mapper.movie.admin.theme;

import com.kerich.archive.dto.movie.admin.theme.ThemeInfoShortDto;
import com.kerich.archive.entity.movie.Theme;
import org.mapstruct.*;

@Mapper(config = com.kerich.archive.config.movie.MupStructConfigDefault.class)
public interface ThemeInfoShortMapper {
    Theme toEntity(ThemeInfoShortDto themeInfoShortDto);

    ThemeInfoShortDto toDto(Theme theme);
}
