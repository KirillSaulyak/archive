package com.kerich.archive.mapper.movie.admin.country;

import com.kerich.archive.dto.movie.admin.country.CountryInfoShortDto;
import com.kerich.archive.entity.movie.Country;
import org.mapstruct.*;

@Mapper(unmappedTargetPolicy = ReportingPolicy.IGNORE)
public interface CountryInfoShortMapper {
    Country toEntity(CountryInfoShortDto countryInfoShortDto);

    CountryInfoShortDto toDto(Country country);
}
