package com.kerich.archive.mapper.movie.admin.actor;

import com.kerich.archive.config.movie.MupStructConfigDefault;
import com.kerich.archive.dto.movie.admin.actor.ActorCreateDto;
import com.kerich.archive.entity.movie.Actor;
import org.mapstruct.*;

@Mapper(config = MupStructConfigDefault.class)
public interface ActorCreateMapper {
    Actor toEntity(ActorCreateDto actorCreateDto);
}
