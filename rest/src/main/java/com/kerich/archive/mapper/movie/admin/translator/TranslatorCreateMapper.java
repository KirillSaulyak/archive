package com.kerich.archive.mapper.movie.admin.translator;

import com.kerich.archive.dto.movie.admin.translator.TranslatorCreateDto;
import com.kerich.archive.entity.movie.Translator;
import org.mapstruct.*;

@Mapper(unmappedTargetPolicy = ReportingPolicy.IGNORE)
public interface TranslatorCreateMapper {
    Translator toEntity(TranslatorCreateDto translatorCreateDto);
}
