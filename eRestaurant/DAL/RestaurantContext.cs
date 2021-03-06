﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using eRestaurant.Entities;

namespace eRestaurant.DAL
{
    public class RestaurantContext : DbContext
    {
        #region Constructor
        public RestaurantContext() : base("name-EatIn") { }
        #endregion

        #region Properties for Table-to-Entity mappings
        public DbSet<Reservation> Reservations { get; set; }    
        public DbSet<SpecialEvent> SpecialEvents { get; set; }
        public DbSet<Bills> Bill { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<MenuCategories> MenuCategories { get; set; }
        public DbSet<Table> Tables { get;set;}
        public DbSet<Waiters> Waiters { get; set; }
        public DbSet<BillItem> BillItem { get; set; }
        #endregion
        #region Over-ride OnModelCreating
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Reservation>().HasMany(r => r.Tables)
                .WithMany(t => t.Reservations)
                .Map(mapping =>
                    {
                        mapping.ToTable("ReservationTables");
                        mapping.MapLeftKey("ReservationID");
                        mapping.MapRightKey("TableID");
                    });
            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}
