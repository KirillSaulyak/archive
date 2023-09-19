package com.kerich.archive.service.movie.actor;

import com.kerich.archive.entity.movie.Actor;
import com.kerich.archive.repository.movie.ActorRepository;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;

@Service
@RequiredArgsConstructor
public class ActorServiceImpl implements ActorService{
    private final ActorRepository actorRepository;

    @Override
    public Actor findById(Long id) {
        return actorRepository.findById(id).orElseThrow();
    }

    @Override
    public Actor saveActor(Actor actor) {
        return actorRepository.save(actor);
    }
}
