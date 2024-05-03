using ProjectAkhir_RAiso.Model;
using ProjectAkhir_RAiso.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;
using System.Web.Util;

namespace ProjectAkhir_RAiso.Handler
{
    public class TransactionHandler
    {
        public static int InitTransaction(int UserID)
        {
            return TransactionRepository.InitTransaction(UserID);
        }

        public static void InsertTransactionDetail(int TransactionID, int StationeryID, int Quantity)
        {
            TransactionRepository.InsertTransactionDetail(TransactionID, StationeryID, Quantity);
        }
    }
}