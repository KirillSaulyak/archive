package com.kerich.archive.service.movie.admin.translator;

import com.kerich.archive.dto.movie.admin.translator.TranslatorSaveDto;
import com.kerich.archive.dto.movie.admin.translator.TranslatorInfoShortDto;
import com.kerich.archive.entity.movie.Translator;
import com.kerich.archive.mapper.movie.admin.translator.TranslatorSaveMapper;
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
    private final TranslatorSaveMapper translatorSaveMapper;

    @Override
    public void saveTranslator(TranslatorSaveDto translatorSaveDto) {
        translatorRepository.save(translatorSaveMapper.toEntity(translatorSaveDto));
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
