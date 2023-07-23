package com.kerich.archive.repository.movie;

import com.kerich.archive.entity.movie.MovieType;
import org.springframework.data.jpa.repository.JpaRepository;

public interface MovieTypeRepository extends JpaRepository<MovieType, Long> {
}