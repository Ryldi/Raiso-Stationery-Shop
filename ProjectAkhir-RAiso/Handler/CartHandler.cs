using ProjectAkhir_RAiso.Model;
using ProjectAkhir_RAiso.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAkhir_RAiso.Handler
{
    public class CartHandler
    {
        public static void AddItemToCart(int Qty, int UserID, int ItemID)
        {
            CartRepository.AddItemToCart(Qty, UserID, ItemID);
        }

        public static Cart GetCart(int UserID, int ItemID)
        {
            return CartRepository.GetCart(UserID, ItemID);
        }

        public static List<Cart> GetAllCartByID(int UserID)
        {
            return CartRepository.GetAllCart(UserID);
        }
    }
}