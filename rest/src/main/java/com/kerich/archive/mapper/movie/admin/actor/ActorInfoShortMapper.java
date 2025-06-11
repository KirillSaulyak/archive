package com.kerich.archive.mapper.movie.admin.actor;

import com.kerich.archive.config.movie.MupStructConfigDefault;
import com.kerich.archive.dto.movie.admin.actor.ActorInfoShortDto;
import com.kerich.archive.entity.movie.Actor;
import org.mapstruct.Mapper;

@Mapper(config = MupStructConfigDefault.class)
public interface ActorInfoShortMapper {
    Actor toEntity(ActorInfoShortDto actorInfoShortDto);

    ActorInfoShortDto toDto(Actor actor);
}
