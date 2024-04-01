package com.kerich.archive.repository.movie;

import com.kerich.archive.entity.movie.Type;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.Optional;

public interface TypeRepository extends JpaRepository<Type, Long> {
    Optional<Type> findTypeById(Long id);
}