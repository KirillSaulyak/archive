using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Type = Archive.Core.Entities.MovieSpace.Type;

namespace Archive.Infrastructure.Persistence.EntityConfigurations.MovieSpace
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
