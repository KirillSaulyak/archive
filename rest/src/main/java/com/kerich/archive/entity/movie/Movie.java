package com.kerich.archive.entity.movie;

import jakarta.persistence.*;
import jakarta.validation.constraints.NotNull;
import jakarta.validation.constraints.Size;
import lombok.*;
import org.hibernate.Hibernate;

import java.time.LocalDate;
import java.util.List;
import java.util.Objects;

@Builder
@AllArgsConstructor
@NoArgsConstructor
@Getter
@Setter
@Entity
@Table(name = "movies", schema = "movie")
public class Movie {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "id", nullable = false)
    private Long id;

    @NotNull
    @Column(name = "release", nullable = false)
    private LocalDate release;

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
    @Column(name = "name", nullable = false, length = 200)
    private String name;

    @Size(max = 45)
    @NotNull
    @Column(name = "name_another", nullable = false, length = 200)
    private String nameAnother;

    @Size(max = 45)
    @NotNull
    @Column(name = "path_to_poster", nullable = false, length = 255)
    private String pathToPoster;

    @NotNull
    @ManyToMany
    @JoinTable(
            schema = "movie",
            name = "movies_actors",
            joinColumns = @JoinColumn(name = "movie_id"),
            inverseJoinColumns = @JoinColumn(name = "actor_id")
    )
    private List<Actor> actors;

    @NotNull
    @ManyToMany
    @JoinTable(
            schema = "movie",
            name = "movies_countries",
            joinColumns = @JoinColumn(name = "movie_id"),
            inverseJoinColumns = @JoinColumn(name = "country_id")
    )
    private List<Country> countries;

    @NotNull
    @ManyToMany
    @JoinTable(
            schema = "movie",
            name = "movies_directors",
            joinColumns = @JoinColumn(name = "movie_id"),
            inverseJoinColumns = @JoinColumn(name = "director_id")
    )
    private List<Director> directors;

    @NotNull
    @ManyToMany
    @JoinTable(
            schema = "movie",
            name = "movies_genres",
            joinColumns = @JoinColumn(name = "movie_id"),
            inverseJoinColumns = @JoinColumn(name = "genre_id")
    )
    private List<Genre> genres;

    @NotNull
    @ManyToMany
    @JoinTable(
            schema = "movie",
            name = "movies_themes",
            joinColumns = @JoinColumn(name = "movie_id"),
            inverseJoinColumns = @JoinColumn(name = "theme_id")
    )
    private List<Theme> themes;

    @NotNull
    @ManyToOne
    @JoinColumn(name = "translator_id", nullable = false)
    private Translator translator;

    @NotNull
    @ManyToOne
    @JoinColumn(name = "type_id", nullable = false)
    private Type type;


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