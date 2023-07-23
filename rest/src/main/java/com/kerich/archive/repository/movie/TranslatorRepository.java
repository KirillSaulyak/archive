package com.kerich.archive.repository.movie;

import com.kerich.archive.entity.movie.Translator;
import org.springframework.data.jpa.repository.JpaRepository;

public interface TranslatorRepository extends JpaRepository<Translator, Long> {
}