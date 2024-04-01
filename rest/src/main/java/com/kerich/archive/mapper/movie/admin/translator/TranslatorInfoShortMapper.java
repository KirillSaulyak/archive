package com.kerich.archive.mapper.movie.admin.translator;

import com.kerich.archive.dto.movie.admin.translator.TranslatorInfoShortDto;
import com.kerich.archive.entity.movie.Translator;
import org.mapstruct.Mapper;
import org.mapstruct.ReportingPolicy;

@Mapper(unmappedTargetPolicy = ReportingPolicy.IGNORE)
public interface TranslatorInfoShortMapper {
    Translator toEntity(TranslatorInfoShortDto translatorInfoShortDto);

    TranslatorInfoShortDto toDto(Translator translator);
}
