package com.kerich.archive.mapper.movie.admin.theme;

import com.kerich.archive.dto.movie.admin.theme.ThemeCreateDto;
import com.kerich.archive.entity.movie.Theme;
import org.mapstruct.*;

@Mapper(config = com.kerich.archive.config.movie.MupStructConfigDefault.class)
public interface ThemeCreateMapper {
    Theme toEntity(ThemeCreateDto themeCreateDto);
}
