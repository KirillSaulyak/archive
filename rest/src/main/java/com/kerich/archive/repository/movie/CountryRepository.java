package com.kerich.archive.repository.movie;

import com.kerich.archive.entity.movie.Country;
import org.springframework.data.jpa.repository.JpaRepository;

public interface CountryRepository extends JpaRepository<Country, Long> {
}