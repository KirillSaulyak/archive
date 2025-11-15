using Archive.Core.Entities.MovieSpace;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Archive.Infrastructure.Persistence.EntityConfigurations.MovieSpace
{
    internal class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(movie => movie.Id);
            builder.Property(movie => movie.Release).IsRequired(false);
            builder.Property(movie => movie.Duration).IsRequired(false);
            builder.Property(movie => movie.Description).IsRequired(false).HasMaxLength(1000);
            builder.Property(movie => movie.Name).IsRequired().HasMaxLength(200);
            builder.Property(movie => movie.OriginalName).IsRequired(false).HasMaxLength(200);
            builder.Property(movie => movie.PosterFileExtension).IsRequired().HasMaxLength(255);
            builder.HasMany(movie => movie.Actors).WithMany(actor => actor.Movies);
            builder.HasMany(movie => movie.Categories).WithMany(category => category.Movies);
            builder.HasMany(movie => movie.Countries).WithMany(country => country.Movies);
            builder.HasMany(movie => movie.Directors).WithMany(director => director.Movies);
            builder.HasMany(movie => movie.Genres).WithMany(genre => genre.Movies);
            builder.HasMany(movie => movie.Themes).WithMany(theme => theme.Movies);
            builder.HasMany(movie => movie.Translators).WithMany(translator => translator.Movies);
        }
    }
}
