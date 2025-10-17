using Archive.Core.Entities.Movies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Archive.Infrastructure.Persistence.EntityConfigurations.Movies
{
    internal class ActorConfiguration : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.HasKey(actor => actor.Id);
            builder.Property(actor => actor.FullName).IsRequired().HasMaxLength(100);
        }
    }
}
