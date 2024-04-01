package com.kerich.archive.repository.movie;

import com.kerich.archive.entity.movie.Country;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface CountryRepository extends JpaRepository<Country, Long> {
    List<Country> findCountryByIdIn(List<Long> ids);
}