package com.kerich.archive.service.movie.admin.translator;

import com.kerich.archive.dto.movie.admin.translator.TranslatorCreateDto;
import com.kerich.archive.dto.movie.admin.translator.TranslatorInfoShortDto;
import com.kerich.archive.entity.movie.Translator;
import com.kerich.archive.mapper.movie.admin.translator.TranslatorCreateMapper;
import com.kerich.archive.mapper.movie.admin.translator.TranslatorInfoShortMapper;
import com.kerich.archive.repository.movie.TranslatorRepository;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.NoSuchElementException;
import java.util.stream.Collectors;

@Service
@RequiredArgsConstructor
public class TranslatorServiceImpl implements TranslatorService {
    private final TranslatorRepository translatorRepository;
    private final TranslatorInfoShortMapper translatorInfoShortMapper;
    private final TranslatorCreateMapper translatorCreateMapper;

    @Override
    public void createTranslator(TranslatorCreateDto translatorCreateDto) {
        translatorRepository.save(translatorCreateMapper.toEntity(translatorCreateDto));
    }

    @Override
    public List<TranslatorInfoShortDto> findAll() {
        return translatorRepository.findAll().stream().map(translatorInfoShortMapper::toDto).collect(Collectors.toList());
    }

    @Override
    public Translator findTranslatorById(Long id) {
        return translatorRepository.findTranslatorById(id).orElseThrow(() -> new NoSuchElementException("Wrong translator id"));
    }
}
