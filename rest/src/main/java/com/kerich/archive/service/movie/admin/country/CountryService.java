package com.kerich.archive.service.movie.admin.country;

import com.kerich.archive.dto.movie.admin.country.CountryInfoShortDto;
import com.kerich.archive.dto.movie.admin.country.CountrySaveDto;
import com.kerich.archive.entity.movie.Country;

import java.util.List;

public interface CountryService {
    void saveCountry(CountrySaveDto countrySaveDto);

    List<CountryInfoShortDto> findAll();

    List<Country> findCountriesByIds(List<Long> ids);
}
