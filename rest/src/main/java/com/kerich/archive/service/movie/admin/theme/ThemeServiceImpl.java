package com.kerich.archive.service.movie.admin.theme;

import com.kerich.archive.dto.movie.admin.theme.ThemeCreateDto;
import com.kerich.archive.dto.movie.admin.theme.ThemeInfoShortDto;
import com.kerich.archive.entity.movie.Theme;
import com.kerich.archive.mapper.movie.admin.theme.ThemeCreateMapper;
import com.kerich.archive.mapper.movie.admin.theme.ThemeInfoShortMapper;
import com.kerich.archive.repository.movie.ThemeRepository;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
@RequiredArgsConstructor
public class ThemeServiceImpl implements ThemeService {
    private final ThemeRepository themeRepository;
    private final ThemeInfoShortMapper themeInfoShortMapper;
    private final ThemeCreateMapper themeCreateMapper;

    @Override
    public void createTheme(ThemeCreateDto themeCreateDto) {
        themeRepository.save(themeCreateMapper.toEntity(themeCreateDto));
    }

    @Override
    public List<ThemeInfoShortDto> findAll() {
        return themeRepository.findAll().stream().map(themeInfoShortMapper::toDto).collect(Collectors.toList());
    }

    @Override
    public List<Theme> findThemesByIds(List<Long> ids) {
        return themeRepository.findThemeByIdIn(ids);
    }
}
