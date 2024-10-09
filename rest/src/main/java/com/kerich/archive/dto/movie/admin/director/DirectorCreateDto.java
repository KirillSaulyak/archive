package com.kerich.archive.dto.movie.admin.director;

import jakarta.validation.constraints.NotNull;
import jakarta.validation.constraints.Size;

/**
 * A DTO for the {@link com.kerich.archive.entity.movie.Director} entity
 */
public record DirectorCreateDto(@Size(max = 100) @NotNull String fullName) {
}