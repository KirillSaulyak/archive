package com.kerich.archive.mapper.movie.admin.country;

import com.kerich.archive.dto.movie.admin.country.CountryCreateDto;
import com.kerich.archive.entity.movie.Country;
import org.mapstruct.*;

@Mapper(config = com.kerich.archive.config.movie.MupStructConfigDefault.class)
public interface CountryCreateMapper {
    Country toEntity(CountryCreateDto countryCreateDto);
}
