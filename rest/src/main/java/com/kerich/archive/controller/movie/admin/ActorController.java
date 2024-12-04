package com.kerich.archive.controller.movie.admin;

import com.kerich.archive.dto.movie.admin.actor.ActorInfoShortDto;
import com.kerich.archive.dto.movie.admin.actor.ActorCreateDto;
import com.kerich.archive.service.movie.admin.actor.ActorService;
import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequiredArgsConstructor
@RequestMapping("/api/movie/admin/actors")
public class ActorController {
    private final ActorService actorService;

    @GetMapping
    public List<ActorInfoShortDto> getActors() {
        return actorService.findAllActorInfoShortDtos();
    }

    @PostMapping
    public void createActor(@RequestBody ActorCreateDto actorCreateDto) throws Exception {
        actorService.createActor(actorCreateDto);
    }
}
