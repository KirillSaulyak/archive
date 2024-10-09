package com.kerich.archive.dto.movie.admin.type;

import jakarta.validation.constraints.NotNull;
import jakarta.validation.constraints.Size;

/**
 * A DTO for the {@link com.kerich.archive.entity.movie.Type} entity
 */
public record TypeCreateDto(@Size(max = 45) @NotNull String name) {
}