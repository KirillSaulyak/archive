package com.kerich.archive.dto.movie.admin.movie;

import jakarta.validation.constraints.NotNull;
import jakarta.validation.constraints.Size;

import java.time.LocalDate;
import java.util.List;

/**
 * A DTO for the {@link com.kerich.archive.entity.movie.Movie} entity
 */
public record MovieSaveDto(@NotNull LocalDate release, @Size(max = 10) @NotNull String duration,
                           @Size(max = 1000) @NotNull String description, @Size(max = 45) @NotNull String name,
                           @Size(max = 45) @NotNull String nameAnother, List<Long> actorIds, List<Long> countryIds,
                           List<Long> directorIds, List<Long> genreIds, List<Long> themeIds, Long translatorId,
                           Long typeId) {
}