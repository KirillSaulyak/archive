package com.kerich.archive.dto.movie.admin.translator;

import jakarta.validation.constraints.NotNull;
import jakarta.validation.constraints.Size;

/**
 * A DTO for the {@link com.kerich.archive.entity.movie.Translator} entity
 */
public record TranslatorInfoShortDto(Long id, @Size(max = 100) @NotNull String fullName) {
}