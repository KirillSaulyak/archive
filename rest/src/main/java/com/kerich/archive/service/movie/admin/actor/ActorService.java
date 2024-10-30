package com.kerich.archive.service.movie.admin.actor;

import com.kerich.archive.dto.movie.admin.actor.ActorInfoShortDto;
import com.kerich.archive.dto.movie.admin.actor.ActorCreateDto;
import com.kerich.archive.entity.movie.Actor;

import java.util.List;

public interface ActorService {

    List<ActorInfoShortDto> findAllActorInfoShortDtos();

    void createActor(ActorCreateDto actorCreateDto);

    List<Actor> findActorsByIds(List<Long> ids);

}