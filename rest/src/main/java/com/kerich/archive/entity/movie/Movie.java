package com.kerich.archive.entity.movie;

import jakarta.persistence.*;
import jakarta.validation.constraints.NotNull;
import jakarta.validation.constraints.Size;
import lombok.*;
import org.hibernate.Hibernate;

import java.time.LocalDate;
import java.util.Objects;

@Builder
@AllArgsConstructor
@NoArgsConstructor
@Getter
@Setter
@Entity
@Table(name = "movie", schema = "movie")
public class Movie {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "id_movie", nullable = false)
    private Long id;

    @NotNull
    @Column(name = "movie_release", nullable = false)
    private LocalDate movieRelease;

    @Size(max = 10)
    @NotNull
    @Column(name = "duration", nullable = false, length = 10)
    private String duration;

    @Size(max = 1000)
    @NotNull
    @Column(name = "description", nullable = false, length = 1000)
    private String description;

    @Size(max = 45)
    @NotNull
    @Column(name = "name", nullable = false, length = 45)
    private String name;

    @Size(max = 45)
    @NotNull
    @Column(name = "name_another", nullable = false, length = 45)
    private String nameAnother;

    @NotNull
    @ManyToOne(fetch = FetchType.LAZY, optional = false)
    @JoinColumn(name = "movie_types_id_movie_type", nullable = false)
    private MovieType movieTypesIdMovieType;

    @NotNull
    @ManyToOne(fetch = FetchType.LAZY, optional = false)
    @JoinColumn(name = "directors_id_director", nullable = false)
    private Director directorsIdDirector;

    @NotNull
    @ManyToOne(fetch = FetchType.LAZY, optional = false)
    @JoinColumn(name = "countries_id_country", nullable = false)
    private Country countriesIdCountry;

    @NotNull
    @ManyToOne(fetch = FetchType.LAZY, optional = false)
    @JoinColumn(name = "genres_id_genre", nullable = false)
    private Genre genresIdGenre;

    @NotNull
    @ManyToOne(fetch = FetchType.LAZY, optional = false)
    @JoinColumn(name = "translators_id_translator", nullable = false)
    private Translator translatorsIdTranslator;

    @ManyToOne(fetch = FetchType.LAZY)
    @JoinColumn(name = "actors_id_actor")
    private Actor actorsIdActor;

    @ManyToOne(fetch = FetchType.LAZY)
    @JoinColumn(name = "movie_themes_id_movie_theme")
    private MovieTheme movieThemesIdMovieTheme;

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || Hibernate.getClass(this) != Hibernate.getClass(o)) return false;
        Movie movie = (Movie) o;
        return id != null && Objects.equals(id, movie.id);
    }

    @Override
    public int hashCode() {
        return getClass().hashCode();
    }
}