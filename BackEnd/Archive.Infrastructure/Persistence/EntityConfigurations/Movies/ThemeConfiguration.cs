using Archive.Core.Entities.Movies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Archive.Infrastructure.Persistence.EntityConfigurations.Movies
{
    internal class ThemeConfiguration : IEntityTypeConfiguration<Theme>
    {
        public void Configure(EntityTypeBuilder<Theme> builder)
        {
            builder.HasKey(theme => theme.Id);
            builder.Property(theme => theme.Name).IsRequired().HasMaxLength(100);
        }
    }
}
