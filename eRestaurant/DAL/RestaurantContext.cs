using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace eRestaurant.DAL
{
    public class RestaurantContext : DBContext
    {
        #region Constructor
        public RestaurantContext() : base("name-EatIn") { }
        #endregion

        #region Properties for Table-to-Entity mappings
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Table> Tables { get;set;}
        public DbSet<SpecialEvent> SpecialEvents { get; set; }
        #endregion
    }
}
