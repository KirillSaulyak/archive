package com.kerich.archive.service.movie.admin.translator;

import com.kerich.archive.dto.movie.admin.translator.TranslatorCreateDto;
import com.kerich.archive.dto.movie.admin.translator.TranslatorInfoShortDto;
import com.kerich.archive.entity.movie.Translator;

import java.util.List;

public interface TranslatorService {
    void createTranslator(TranslatorCreateDto translatorCreateDto);

    List<TranslatorInfoShortDto> findAll();

    Translator findTranslatorById(Long id);
}
