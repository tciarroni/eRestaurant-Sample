using eRestaurant.DAL;
using eRestaurant.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.BLL
{
   public class RestaurantAdminController
   {
       #region Manage Waiters
       #region Command
       public int AddWaiter(Waiters item)
       {
           using (RestaurantContext context = new RestaurantContext())
           {
               // todo validation rules...
               var added = context.Waiters.Add(item);
               context.SaveChanges();
               return added.WaiterID;
           }
       }
       public void UpdateWaiter(Waiters item)
       {
           using (RestaurantContext context = new RestaurantContext())
           {
               var attached = context.Waiters.Attach(item);
               var existing = context.Entry<Waiters>(attached);
               existing.State = System.Data.Entity.EntityState.Modified;
               context.SaveChanges();
           }
       }
       public void DeleteWaiter(Waiters item)
       {
           using (RestaurantContext context = new RestaurantContext())
           {
               var existing = context.Waiters.Find(item.WaiterID);
               context.Waiters.Remove(existing);
               context.SaveChanges();
           }
       }
       #endregion
       #region Query
       public List<Waiters> ListAllWaiters()
       {
           using (RestaurantContext context = new RestaurantContext())
           {
               return context.Waiters.ToList();
           }
       }
       public Waiters GetWaiter(int WaiterID)
       {
           using(RestaurantContext context = new RestaurantContext())
           {
               return context.Waiters.Find(WaiterID);
           }
       }
       #endregion
       #endregion

       #region Manage Tables
       #region Command
       #endregion
       #region Query
       #endregion
       #endregion

       #region Manage Items
       #region Command
       #endregion
       #region Query
       #endregion
       #endregion

       #region Manage SpecialEvents
       #region Command
       #endregion
       #region Query
       #endregion
       #endregion
   }
}
