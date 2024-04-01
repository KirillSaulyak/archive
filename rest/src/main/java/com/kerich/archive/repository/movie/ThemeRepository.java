package com.kerich.archive.repository.movie;

import com.kerich.archive.entity.movie.Theme;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface ThemeRepository extends JpaRepository<Theme, Long> {
    List<Theme> findThemeByIdIn(List<Long> ids);
}