package com.kerich.archive.service.movie.actor;

import com.kerich.archive.entity.movie.Actor;

public interface ActorService {
    Actor findById(Long id);

    Actor saveActor(Actor actor);
}