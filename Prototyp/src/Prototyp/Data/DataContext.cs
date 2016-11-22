using Microsoft.EntityFrameworkCore;
using Prototyp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prototyp.Data
{
    public class DataContext : DbContext

    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
            public DbSet<Interpreten> Interpreten { get; set; }
        


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Interpreten>().ToTable("Interpreten");

        }

    
    } 
}

