package com.kerich.archive.dto.movie.admin.country;

import jakarta.validation.constraints.NotNull;
import jakarta.validation.constraints.Size;

/**
 * A DTO for the {@link com.kerich.archive.entity.movie.Country} entity
 */
public record CountryInfoShortDto(Long id, @Size(max = 100) @NotNull String name) {
}