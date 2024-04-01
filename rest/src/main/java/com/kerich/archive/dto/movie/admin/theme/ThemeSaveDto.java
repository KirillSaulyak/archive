package com.kerich.archive.dto.movie.admin.theme;

import jakarta.validation.constraints.NotNull;
import jakarta.validation.constraints.Size;

/**
 * A DTO for the {@link com.kerich.archive.entity.movie.Theme} entity
 */
public record ThemeSaveDto(@Size(max = 100) @NotNull String name) {
}