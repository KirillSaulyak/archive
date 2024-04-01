package com.kerich.archive.controller.movie.admin;

import com.kerich.archive.dto.movie.admin.type.TypeSaveDto;
import com.kerich.archive.dto.movie.admin.type.TypeInfoShortDto;
import com.kerich.archive.service.movie.admin.type.TypeService;
import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequiredArgsConstructor
@RequestMapping("/api/movie/admin/types")
public class TypeController {
    private final TypeService typeService;

    @GetMapping
    public List<TypeInfoShortDto> getTypes() {
        return typeService.findAll();
    }

    @PostMapping
    public void saveType(@RequestBody TypeSaveDto typeSaveDto) {
        typeService.saveType(typeSaveDto);
    }
}
