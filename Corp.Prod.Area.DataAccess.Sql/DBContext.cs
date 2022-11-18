using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Corp.Prod.DataAccess.Entities;
using Microsoft.Extensions.Logging;

namespace Corp.Prod.DataAccess.Sql
{
    internal class DBContext : DbContext
    {
        private readonly ILogger<DBContext> _logger;
        public DBContext(ILogger<DBContext> logger)
        {
            _logger = logger;
        }
        public DbSet<Parcel> Parcels { get; set; }
        public DbSet<Warehouse> Warehouses {get; set; }
        public DbSet<Hop> Hops { get; set; }
        public DbSet<HopArrival> HopArrivals { get; set; }
        public DbSet<Recipient> Recipients { get; set; }
        public DbSet<Transferwarehouse> Transferwarehouses { get; set; }
        public DbSet<Truck> Trucks { get; set; }
        public DbSet<WarehouseNextHops> WarehousesNextHops { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Parcel>().ToTable("parcels");
            modelBuilder.Entity<Parcel>().Property(p => p.Id).HasColumnName("parcel_id").HasColumnType("int");
        }


    }
}
