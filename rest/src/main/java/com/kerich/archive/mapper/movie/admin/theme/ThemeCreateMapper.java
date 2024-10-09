package com.kerich.archive.mapper.movie.admin.theme;

import com.kerich.archive.dto.movie.admin.theme.ThemeCreateDto;
import com.kerich.archive.entity.movie.Theme;
import org.mapstruct.*;

@Mapper(unmappedTargetPolicy = ReportingPolicy.IGNORE)
public interface ThemeCreateMapper {
    Theme toEntity(ThemeCreateDto themeCreateDto);
}
