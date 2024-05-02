using ProjectAkhir_RAiso.Handler;
using ProjectAkhir_RAiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace ProjectAkhir_RAiso.Controller
{
    public class CartController
    {
        public static string AddItemToCart(int Qty, int UserID, int ItemID)
        {
            if(Qty <= 0)
            {
                return "Quantity must be at least 1";
            }

            if(UserID == 0 || ItemID == 0)
            {
                return "Error! A wild problem has appeared.";
            }

            if(CartHandler.GetCart(UserID, ItemID) != null)
            {
                return "Item is already in cart.";
            }

            CartHandler.AddItemToCart(Qty, UserID, ItemID);
            return "Successfully added to cart.";
        }

        public static List<dynamic> GetCartInformation(int UserID)
        {
            List<Cart> carts = CartHandler.GetAllCartByID(UserID);

            List<dynamic> CartDetail = new List<dynamic>();
            foreach (Cart cart in carts)
            {
                Stationery item = StationeryController.findItem(cart.StationeryID);
                CartDetail.Add(new
                {
                    StationeryID = cart.StationeryID,
                    StationeryName = item.StationeryName,
                    StationeryPrice = item.StationeryPrice,
                    Quantity = cart.Quantity
                });
            }


            return CartDetail;
        }
    }
}