using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Type = Archive.Core.Entities.Movies.Type;

namespace Archive.Infrastructure.Persistence.EntityConfigurations.Movies
{
    internal class TypeConfiguration : IEntityTypeConfiguration<Type>
    {
        public void Configure(EntityTypeBuilder<Type> builder)
        {
            builder.HasKey(type => type.Id);
            builder.Property(type => type.Name).IsRequired().HasMaxLength(45);
        }
    }
}
