using ProjectAkhir_RAiso.Factory;
using ProjectAkhir_RAiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAkhir_RAiso.Repository
{
    public class CartRepository
    {
        private static StationeryDBEntities _db = DatabaseSingleton.GetInstance();

        public static void AddItemToCart(int Qty, int UserID, int ItemID)
        {
            Cart newCart = CartFactory.CreateCart(Qty, UserID, ItemID);

            if (newCart == null ) { return; }

            _db.Carts.Add(newCart);
            _db.SaveChanges();
        }

        public static Cart GetCart(int UserID, int ItemID)
        {
            Cart cart = _db.Carts.Where(x => x.UserID == UserID && x.StationeryID == ItemID).FirstOrDefault();

            if (cart == null) { return null; }

            return cart;
        }

        public static List<Cart> GetAllCart(int UserID)
        {
            List<Cart> carts = _db.Carts.Where(x => x.UserID == UserID).ToList();

            if (_db.Carts == null || carts == null)
            {
                return null;
            }

            return carts;
        }
    }
}