package com.kerich.archive.mapper.movie.admin.movie;

import com.kerich.archive.dto.movie.admin.movie.MovieInfoDto;
import com.kerich.archive.entity.movie.*;
import org.mapstruct.*;

import java.util.List;
import java.util.stream.Collectors;

@Mapper(unmappedTargetPolicy = ReportingPolicy.IGNORE)
public interface MovieInfoMapper {
    @Mapping(target = "actorIds", expression = "java(actorsToActorIds(movie.getActors()))")
    @Mapping(target = "countryIds", expression = "java(countriesToCountryIds(movie.getCountries()))")
    @Mapping(target = "directorIds", expression = "java(directorsToDirectorIds(movie.getDirectors()))")
    @Mapping(target = "genreIds", expression = "java(genresToGenreIds(movie.getGenres()))")
    @Mapping(target = "themeIds", expression = "java(themesToThemeIds(movie.getThemes()))")
    @Mapping(target = "translatorId", source = "translator.id")
    @Mapping(target = "typeId", source = "type.id")
    MovieInfoDto toDto(Movie movie);

    default List<Long> actorsToActorIds(List<Actor> actors) {
        return actors.stream().map(Actor::getId).collect(Collectors.toList());
    }

    default List<Long> countriesToCountryIds(List<Country> countries) {
        return countries.stream().map(Country::getId).collect(Collectors.toList());
    }

    default List<Long> directorsToDirectorIds(List<Director> directors) {
        return directors.stream().map(Director::getId).collect(Collectors.toList());
    }

    default List<Long> genresToGenreIds(List<Genre> genres) {
        return genres.stream().map(Genre::getId).collect(Collectors.toList());
    }

    default List<Long> themesToThemeIds(List<Theme> themes) {
        return themes.stream().map(Theme::getId).collect(Collectors.toList());
    }
}
