package com.kerich.archive.repository.movie;

import com.kerich.archive.entity.movie.Director;
import org.springframework.data.jpa.repository.JpaRepository;

public interface DirectorRepository extends JpaRepository<Director, Long> {
}