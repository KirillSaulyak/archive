package com.kerich.archive.mapper.movie.admin.movie;

import com.kerich.archive.dto.movie.admin.movie.MovieSaveDto;
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

@Mapper(unmappedTargetPolicy = ReportingPolicy.IGNORE)

public abstract class MovieSaveMapper {
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

    @Mapping(target = "actors", expression = "java(actorService.findActorsByIds(movieSaveDto.actorIds()))")
    @Mapping(target = "countries", expression = "java(countryService.findCountriesByIds(movieSaveDto.countryIds()))")
    @Mapping(target = "directors", expression = "java(directorService.findDirectorsByIds(movieSaveDto.directorIds()))")
    @Mapping(target = "genres", expression = "java(genreService.findGenresByIds(movieSaveDto.genreIds()))")
    @Mapping(target = "themes", expression = "java(themeService.findThemesByIds(movieSaveDto.themeIds()))")
    @Mapping(target = "translator.id", source = "translatorId")
    @Mapping(target = "type.id", source = "typeId")
    public abstract Movie toEntity(MovieSaveDto movieSaveDto);

    @Mapping(target = "actorIds", expression = "java(actorsToIds(movie.getActors()))")
    @Mapping(target = "countryIds", expression = "java(countriesToIds(movie.getCountries()))")
    @Mapping(target = "directorIds", expression = "java(directorsToIds(movie.getDirectors()))")
    @Mapping(target = "genreIds", expression = "java(genresToIds(movie.getGenres()))")
    @Mapping(target = "themeIds", expression = "java(themesToIds(movie.getThemes()))")
    @Mapping(target = "translatorId", source = "translator.id")
    @Mapping(target = "typeId", source = "type.id")
    public abstract MovieSaveDto toDto(Movie movie);

    protected List<Long> actorsToIds(List<Actor> actors) {
        return actors.stream().map(Actor::getId).collect(Collectors.toList());
    }

    protected List<Long> countriesToIds(List<Country> countries) {
        return countries.stream().map(Country::getId).collect(Collectors.toList());
    }

    protected List<Long> directorsToIds(List<Director> directors) {
        return directors.stream().map(Director::getId).collect(Collectors.toList());
    }

    protected List<Long> genresToIds(List<Genre> genres) {
        return genres.stream().map(Genre::getId).collect(Collectors.toList());
    }

    protected List<Long> themesToIds(List<Theme> themes) {
        return themes.stream().map(Theme::getId).collect(Collectors.toList());
    }
}
