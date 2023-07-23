package com.kerich.archive.repository.movie;

import com.kerich.archive.entity.movie.Actor;
import org.springframework.data.jpa.repository.JpaRepository;

public interface ActorRepository extends JpaRepository<Actor, Long> {
}