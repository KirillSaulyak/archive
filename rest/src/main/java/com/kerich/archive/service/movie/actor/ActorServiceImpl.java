package com.kerich.archive.service.movie.actor;

import com.kerich.archive.repository.movie.ActorRepository;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;

@Service
@RequiredArgsConstructor
public class ActorServiceImpl implements ActorService{
    private final ActorRepository actorRepository;

}
