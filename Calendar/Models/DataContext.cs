using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Calendar.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>()
                .Property(e => e.Subject)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Event>()
                .Property(e => e.Description)
                .HasMaxLength(300);

            modelBuilder.Entity<Event>()
                .Property(e => e.Start)
                .IsRequired();

            modelBuilder.Entity<Event>()
                .Property(e => e.ThemeColor)
                .HasMaxLength(10);


        }

        public DbSet<Event> Events { get; set; }
    }
}
