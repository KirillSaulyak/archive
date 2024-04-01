package com.kerich.archive.repository.movie;

import com.kerich.archive.entity.movie.Actor;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface ActorRepository extends JpaRepository<Actor, Long> {
    List<Actor> findActorByIdIn(List<Long> ids);
}