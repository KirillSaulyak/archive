package com.kerich.archive.mapper.movie.admin.actor;

import com.kerich.archive.dto.movie.admin.actor.ActorSaveDto;
import com.kerich.archive.entity.movie.Actor;
import org.mapstruct.*;

@Mapper(unmappedTargetPolicy = ReportingPolicy.IGNORE)
public interface ActorSaveMapper {
    Actor toEntity(ActorSaveDto actorSaveDto);
}
