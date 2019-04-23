using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Domain.Enitiies;

namespace Domain.DataContext
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        { }

        public DbSet<Qtype> Qtypes  { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Song> Songs  { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Qtype>().ToTable("Qtypes");
            modelBuilder.Entity<Question>().ToTable("Questions");
            modelBuilder.Entity<Song>().ToTable("Songs");
        }
    }
}
