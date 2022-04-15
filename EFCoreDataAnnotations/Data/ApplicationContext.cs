using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreDataAnnotations.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EFCoreQuerys.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Airport> Airports {get; set;}
        public DbSet<Flight> Flights {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlite("Data source=SQLiteDatabase.sqlite")
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging();
        }

    }
}