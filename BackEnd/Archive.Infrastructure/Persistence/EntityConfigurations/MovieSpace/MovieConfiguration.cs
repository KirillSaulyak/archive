using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archive.Core.Entities.MovieSpace;

namespace Archive.Infrastructure.Persistence.EntityConfigurations.MovieSpace
{
    internal class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(movie => movie.Id);
            builder.Property(movie => movie.Release);
            builder.Property(movie => movie.Duration);
            builder.Property(movie => movie.Description).HasMaxLength(1000);
            builder.Property(movie => movie.Name).HasMaxLength(200);
            builder.Property(movie => movie.OriginalName).HasMaxLength(200);
            builder.Property(movie => movie.PathToPoster).HasMaxLength(255);
            builder.HasMany(movie => movie.Actors).WithMany(actor => actor.Movies);
            builder.HasMany(movie => movie.Countries).WithMany(country => country.Movies);
            builder.HasMany(movie => movie.Directors).WithMany(director => director.Movies);
            builder.HasMany(movie => movie.Genres).WithMany(genre => genre.Movies);
            builder.HasMany(movie => movie.Themes).WithMany(theme => theme.Movies);
            builder.HasMany(movie => movie.Translators).WithMany(translator => translator.Movies);
            builder.HasMany(movie => movie.Types).WithMany(type => type.Movies);
        }
    }
}
