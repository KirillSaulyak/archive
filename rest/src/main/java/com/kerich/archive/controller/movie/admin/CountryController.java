package com.kerich.archive.controller.movie.admin;

import com.kerich.archive.dto.movie.admin.country.CountryCreateDto;
import com.kerich.archive.dto.movie.admin.country.CountryInfoShortDto;
import com.kerich.archive.service.movie.admin.country.CountryService;
import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequiredArgsConstructor
@RequestMapping("/api/movie/admin/countries")
public class CountryController {
    private final CountryService countryService;

    @GetMapping
    public List<CountryInfoShortDto> getCountries() {
        return countryService.findAll();
    }

    @PostMapping
    public void createCountry(@RequestBody CountryCreateDto countryCreateDto) {
        countryService.createCountry(countryCreateDto);
    }
}
