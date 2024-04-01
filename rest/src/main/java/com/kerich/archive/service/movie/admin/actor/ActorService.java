package com.kerich.archive.service.movie.admin.actor;

import com.kerich.archive.dto.movie.admin.actor.ActorInfoShortDto;
import com.kerich.archive.dto.movie.admin.actor.ActorSaveDto;
import com.kerich.archive.entity.movie.Actor;

import java.util.List;

public interface ActorService {

    List<ActorInfoShortDto> findAllActorInfoShortDtos();

    void saveActor(ActorSaveDto actorSaveDto);

    List<Actor> findActorsByIds(List<Long> ids);
}