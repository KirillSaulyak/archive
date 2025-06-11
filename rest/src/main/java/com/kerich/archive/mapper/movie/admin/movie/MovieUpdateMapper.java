package com.kerich.archive.mapper.movie.admin.movie;

import com.kerich.archive.dto.movie.admin.movie.MovieUpdateDto;
import com.kerich.archive.entity.movie.*;
import com.kerich.archive.service.movie.admin.actor.ActorService;
import com.kerich.archive.service.movie.admin.country.CountryService;
import com.kerich.archive.service.movie.admin.director.DirectorService;
import com.kerich.archive.service.movie.admin.genre.GenreService;
import com.kerich.archive.service.movie.admin.theme.ThemeService;
import com.kerich.archive.service.movie.admin.translator.TranslatorService;
import com.kerich.archive.service.movie.admin.type.TypeService;
import org.mapstruct.*;
import org.springframework.beans.factory.annotation.Autowired;

import java.util.List;
import java.util.stream.Collectors;

@Mapper(config = com.kerich.archive.config.movie.MupStructConfigDefault.class)
public abstract class MovieUpdateMapper {
    @Autowired
    protected ActorService actorService;

    @Autowired
    protected CountryService countryService;

    @Autowired
    protected DirectorService directorService;

    @Autowired
    protected GenreService genreService;

    @Autowired
    protected ThemeService themeService;

    @Autowired
    protected TranslatorService translatorService;

    @Autowired
    protected TypeService typeService;

    public abstract Movie toEntity(MovieUpdateDto movieUpdateDto);

    @Mapping(target = "id", ignore = true)
    @Mapping(target = "actors", expression = "java(actorService.findActorsByIds(movieUpdateDto.actorIds()))")
    @Mapping(target = "countries", expression = "java(countryService.findCountriesByIds(movieUpdateDto.countryIds()))")
    @Mapping(target = "directors", expression = "java(directorService.findDirectorsByIds(movieUpdateDto.directorIds()))")
    @Mapping(target = "genres", expression = "java(genreService.findGenresByIds(movieUpdateDto.genreIds()))")
    @Mapping(target = "themes", expression = "java(themeService.findThemesByIds(movieUpdateDto.themeIds()))")
    @Mapping(target = "translator", expression = "java(translatorService.findTranslatorById(movieUpdateDto.translatorId()))")
    @Mapping(target = "type", expression = "java(typeService.findTypeById(movieUpdateDto.typeId()))")
    public abstract Movie updateMovieFromDto(@MappingTarget Movie movie, MovieUpdateDto movieUpdateDto);

    @Mapping(target = "actorIds", expression = "java(actorsToActorIds(movie.getActors()))")
    @Mapping(target = "countryIds", expression = "java(countriesToCountryIds(movie.getCountries()))")
    @Mapping(target = "directorIds", expression = "java(directorsToDirectorIds(movie.getDirectors()))")
    @Mapping(target = "genreIds", expression = "java(genresToGenreIds(movie.getGenres()))")
    @Mapping(target = "themeIds", expression = "java(themesToThemeIds(movie.getThemes()))")
    @Mapping(target = "translatorId", source = "translator.id")
    @Mapping(target = "typeId", source = "type.id")
    public abstract MovieUpdateDto toDto(Movie movie);

    protected List<Long> actorsToActorIds(List<Actor> actors) {
        return actors.stream().map(Actor::getId).collect(Collectors.toList());
    }

    protected List<Long> countriesToCountryIds(List<Country> countries) {
        return countries.stream().map(Country::getId).collect(Collectors.toList());
    }

    protected List<Long> directorsToDirectorIds(List<Director> directors) {
        return directors.stream().map(Director::getId).collect(Collectors.toList());
    }

    protected List<Long> genresToGenreIds(List<Genre> genres) {
        return genres.stream().map(Genre::getId).collect(Collectors.toList());
    }

    protected List<Long> themesToThemeIds(List<Theme> themes) {
        return themes.stream().map(Theme::getId).collect(Collectors.toList());
    }
}
