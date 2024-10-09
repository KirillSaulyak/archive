package com.kerich.archive.service.movie.admin.actor;

import com.kerich.archive.dto.movie.admin.actor.ActorCreateDto;
import com.kerich.archive.dto.movie.admin.actor.ActorInfoShortDto;
import com.kerich.archive.entity.movie.Actor;
import com.kerich.archive.mapper.movie.admin.actor.ActorInfoShortMapper;
import com.kerich.archive.mapper.movie.admin.actor.ActorCreateMapper;
import com.kerich.archive.repository.movie.ActorRepository;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
@RequiredArgsConstructor
public class ActorServiceImpl implements ActorService {
    private final ActorRepository actorRepository;
    private final ActorInfoShortMapper actorInfoShortMapper;
    private final ActorCreateMapper actorCreateMapper;

    @Override
    public List<ActorInfoShortDto> findAllActorInfoShortDtos() {
        return actorRepository.findAll().stream().map(actorInfoShortMapper::toDto).collect(Collectors.toList());
    }

    @Override
    public void createActor(ActorCreateDto actorCreateDto) {
        actorRepository.save(actorCreateMapper.toEntity(actorCreateDto));
    }

    @Override
    public List<Actor> findActorsByIds(List<Long> ids) {
        return actorRepository.findActorByIdIn(ids);
    }
}
