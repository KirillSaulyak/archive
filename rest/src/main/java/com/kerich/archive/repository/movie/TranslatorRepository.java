package com.kerich.archive.repository.movie;

import com.kerich.archive.entity.movie.Translator;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.Optional;

public interface TranslatorRepository extends JpaRepository<Translator, Long> {
    Optional<Translator> findTranslatorById(Long id);
}