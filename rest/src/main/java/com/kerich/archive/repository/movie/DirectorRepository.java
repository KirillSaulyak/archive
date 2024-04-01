package com.kerich.archive.repository.movie;

import com.kerich.archive.entity.movie.Director;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface DirectorRepository extends JpaRepository<Director, Long> {
    List<Director> findDirectorByIdIn(List<Long> ids);
}