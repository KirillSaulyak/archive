using Archive.Core.Entities.Movies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Archive.Infrastructure.Persistence.EntityConfigurations.Movies
{
    internal class TranslatorConfiguration : IEntityTypeConfiguration<Translator>
    {
        public void Configure(EntityTypeBuilder<Translator> builder)
        {
            builder.HasKey(translator => translator.Id);
            builder.Property(translator => translator.FullName).IsRequired().HasMaxLength(100);
        }
    }
}
