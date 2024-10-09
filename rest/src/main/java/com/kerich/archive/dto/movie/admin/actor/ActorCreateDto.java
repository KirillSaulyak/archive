package com.kerich.archive.dto.movie.admin.actor;

import jakarta.validation.constraints.NotNull;
import jakarta.validation.constraints.Size;

/**
 * A DTO for the {@link com.kerich.archive.entity.movie.Actor} entity
 */
public record ActorCreateDto(Long id, @Size(max = 100) @NotNull String fullName) {
}