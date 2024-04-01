package com.kerich.archive.mapper.movie.admin.translator;

import com.kerich.archive.dto.movie.admin.translator.TranslatorSaveDto;
import com.kerich.archive.entity.movie.Translator;
import org.mapstruct.*;

@Mapper(unmappedTargetPolicy = ReportingPolicy.IGNORE)
public interface TranslatorSaveMapper {
    Translator toEntity(TranslatorSaveDto translatorSaveDto);
}
