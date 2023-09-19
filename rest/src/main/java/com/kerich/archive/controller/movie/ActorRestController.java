package com.kerich.archive.controller.movie;

import com.kerich.archive.entity.movie.Actor;
import com.kerich.archive.service.movie.actor.ActorService;
import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequiredArgsConstructor
public class ActorRestController {
    private final ActorService actorService;

    @PostMapping("/actor")
    public Actor saveActor(@RequestBody Actor actor)
    {
        return actorService.saveActor(actor);
    }
}
