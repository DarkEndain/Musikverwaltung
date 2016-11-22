using Microsoft.EntityFrameworkCore;
using Prototyp_Net_Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prototyp_Net_Framework.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Interpret> Interpreten{ get; set; }
        public DbSet<Album> Alben { get; set; }
        public DbSet<Song> Songs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Interpret>().ToTable("Interpreten");
            modelBuilder.Entity<Album>().ToTable("Alben");
            modelBuilder.Entity<Song>().ToTable("Songs");
            
        }
    }
}
