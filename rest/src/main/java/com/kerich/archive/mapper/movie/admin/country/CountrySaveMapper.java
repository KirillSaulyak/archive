package com.kerich.archive.mapper.movie.admin.country;

import com.kerich.archive.dto.movie.admin.country.CountrySaveDto;
import com.kerich.archive.entity.movie.Country;
import org.mapstruct.*;

@Mapper(unmappedTargetPolicy = ReportingPolicy.IGNORE)
public interface CountrySaveMapper {
    Country toEntity(CountrySaveDto countrySaveDto);
}
