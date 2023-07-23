package com.kerich.archive.repository.movie;

import com.kerich.archive.entity.movie.MovieTheme;
import org.springframework.data.jpa.repository.JpaRepository;

public interface MovieThemeRepository extends JpaRepository<MovieTheme, Long> {
}