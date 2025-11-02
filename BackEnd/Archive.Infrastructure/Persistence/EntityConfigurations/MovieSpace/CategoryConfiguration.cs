using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Category = Archive.Core.Entities.MovieSpace.Category;

namespace Archive.Infrastructure.Persistence.EntityConfigurations.MovieSpace
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(category => category.Id);
            builder.Property(category => category.Name).IsRequired().HasMaxLength(45);
        }
    }
}

