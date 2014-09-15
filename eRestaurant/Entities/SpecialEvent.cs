using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;// used for the [key] attribute
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities
{
    public class SpecialEvent
    {

         public SpecialEvent()
        {
            Active = true;
        }


        [Key] // identifies the property as mapping to a primary key
        public string EventCode { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

        #region Navigation Properties
        public virtual ICollection<Reservation> Reservations { get; set; }
        #endregion
    }
}
