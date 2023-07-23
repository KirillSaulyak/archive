package com.kerich.archive.repository.movie;

import com.kerich.archive.entity.movie.Genre;
import org.springframework.data.jpa.repository.JpaRepository;

public interface GenreRepository extends JpaRepository<Genre, Long> {
}