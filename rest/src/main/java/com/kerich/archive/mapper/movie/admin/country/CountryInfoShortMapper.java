package com.kerich.archive.mapper.movie.admin.country;

import com.kerich.archive.dto.movie.admin.country.CountryInfoShortDto;
import com.kerich.archive.entity.movie.Country;
import org.mapstruct.*;

@Mapper(config = com.kerich.archive.config.movie.MupStructConfigDefault.class)
public interface CountryInfoShortMapper {
    Country toEntity(CountryInfoShortDto countryInfoShortDto);

    CountryInfoShortDto toDto(Country country);
}
