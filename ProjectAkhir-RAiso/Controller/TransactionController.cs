using ProjectAkhir_RAiso.Handler;
using ProjectAkhir_RAiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace ProjectAkhir_RAiso.Controller
{
    public class TransactionController
    {
        public static void Checkout(int UserID)
        {
            if (UserID == 0) { return; }

            int TransactionID = TransactionHandler.InitTransaction(UserID);

            List<dynamic> carts = CartController.GetCartInformation(UserID);

            foreach (dynamic cart in carts)
            {
                TransactionHandler.InsertTransactionDetail(TransactionID, cart.StationeryID, cart.Quantity);
                CartController.DeleteItemFromCart(UserID, cart.StationeryName);
            }
        }
        public static List<dynamic> GetTransactionInformation(int UserID)
        {
            List<TransactionHeader> Transaction = TransactionHandler.GetUserTransaction(UserID);
            List<dynamic> TransactionList = new List<dynamic>();

            foreach (TransactionHeader transaction in Transaction)
            {
                TransactionList.Add(new
                {
                    TransactionID = transaction.TransactionID,
                    TransactionDate = transaction.TransactionDate,
                    UserName = UserController.GetUserName(UserID)
                });
            }

            return TransactionList;
        }
    }
}