package com.kerich.archive.dto.movie.admin.genre;

import jakarta.validation.constraints.NotNull;
import jakarta.validation.constraints.Size;

/**
 * A DTO for the {@link com.kerich.archive.entity.movie.Genre} entity
 */
public record GenreInfoShortDto(Long id, @Size(max = 45) @NotNull String name) {
}