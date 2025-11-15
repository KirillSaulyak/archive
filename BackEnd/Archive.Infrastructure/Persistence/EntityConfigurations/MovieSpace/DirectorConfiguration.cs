using Archive.Core.Entities.MovieSpace;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Archive.Infrastructure.Persistence.EntityConfigurations.MovieSpace
{
    internal class DirectorConfiguration : IEntityTypeConfiguration<Director>
    {
        public void Configure(EntityTypeBuilder<Director> builder)
        {
            builder.HasKey(director => director.Id);
            builder.Property(director => director.FullName).IsRequired().HasMaxLength(100);
        }
    }
}
