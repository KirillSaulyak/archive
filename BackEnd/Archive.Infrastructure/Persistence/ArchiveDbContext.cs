﻿using Archive.Core.Entities.Movies;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = Archive.Core.Entities.Movies.Type;

namespace Archive.Infrastructure.Persistence
{
    public class ArchiveDbContext(DbContextOptions options) : DbContext(options)
    {

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Translator> Translators { get; set; }
        public DbSet<Type> Types { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ArchiveDbContext).Assembly);
        }
    }
}
