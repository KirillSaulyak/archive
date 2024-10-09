package com.kerich.archive.service.movie.admin.country;

import com.kerich.archive.dto.movie.admin.country.CountryCreateDto;
import com.kerich.archive.dto.movie.admin.country.CountryInfoShortDto;
import com.kerich.archive.entity.movie.Country;
import com.kerich.archive.mapper.movie.admin.country.CountryCreateMapper;
import com.kerich.archive.mapper.movie.admin.country.CountryInfoShortMapper;
import com.kerich.archive.repository.movie.CountryRepository;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
@RequiredArgsConstructor
public class CountryServiceImpl implements CountryService {
    private final CountryRepository countryRepository;
    private final CountryInfoShortMapper countryInfoShortMapper;

    private final CountryCreateMapper countryCreateMapper;

    @Override
    public void createCountry(CountryCreateDto countryCreateDto) {
        countryRepository.save(countryCreateMapper.toEntity(countryCreateDto));
    }

    @Override
    public List<CountryInfoShortDto> findAll() {
        return countryRepository.findAll().stream().map(countryInfoShortMapper::toDto).collect(Collectors.toList());
    }

    @Override
    public List<Country> findCountriesByIds(List<Long> ids) {
        return countryRepository.findCountryByIdIn(ids);
    }
}
