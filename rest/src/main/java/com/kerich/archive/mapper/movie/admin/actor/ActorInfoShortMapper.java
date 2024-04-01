package com.kerich.archive.mapper.movie.admin.actor;

import com.kerich.archive.dto.movie.admin.actor.ActorInfoShortDto;
import com.kerich.archive.entity.movie.Actor;
import org.mapstruct.Mapper;
import org.mapstruct.ReportingPolicy;

@Mapper(unmappedTargetPolicy = ReportingPolicy.IGNORE)
public interface ActorInfoShortMapper {
    Actor toEntity(ActorInfoShortDto actorInfoShortDto);

    ActorInfoShortDto toDto(Actor actor);
}
