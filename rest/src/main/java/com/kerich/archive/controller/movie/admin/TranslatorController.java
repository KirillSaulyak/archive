package com.kerich.archive.controller.movie.admin;

import com.kerich.archive.dto.movie.admin.translator.TranslatorCreateDto;
import com.kerich.archive.dto.movie.admin.translator.TranslatorInfoShortDto;
import com.kerich.archive.service.movie.admin.translator.TranslatorService;
import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequiredArgsConstructor
@RequestMapping("/api/movie/admin/translators")
public class TranslatorController {
    private final TranslatorService translatorService;

    @GetMapping
    public List<TranslatorInfoShortDto> getTranslators() {
        return translatorService.findAll();
    }

    @PostMapping
    public void createTranslator(@RequestBody TranslatorCreateDto translatorCreateDto) {
        translatorService.createTranslator(translatorCreateDto);
    }
}
