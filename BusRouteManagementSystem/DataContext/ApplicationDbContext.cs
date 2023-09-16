using BusRouteManagementSystem.Model;
using BusRouteManagementSystem.Seed;
using Microsoft.EntityFrameworkCore;
using System;

namespace BusRouteManagementSystem.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Bus> Bus { get; set; }
        public DbSet<BusStop> BusStop { get; set; }
        public DbSet<BusBusStop> BusBusStops { get; set; }
        
       /* Hasdata declare gareko*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Bus>().HasData(BusManagementSeed.Bus);
            modelBuilder.Entity<BusStop>().HasData(BusManagementSeed.BusStop);
            modelBuilder.Entity<BusBusStop>().HasData(BusManagementSeed.BusBusStop);

        }

    }
}

