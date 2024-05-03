using ProjectAkhir_RAiso.Factory;
using ProjectAkhir_RAiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAkhir_RAiso.Repository
{
    public class TransactionRepository
    {
        private static StationeryDBEntities _db = DatabaseSingleton.GetInstance();
        public static int InitTransaction(int UserID)
        {
            TransactionHeader newHeader = TransactionFactory.CreateHeader(UserID);

            _db.TransactionHeaders.Add(newHeader);
            _db.SaveChanges();

            return newHeader.TransactionID;
        }

        public static void InsertTransactionDetail(int TransactionID, int StationeryID, int Quantity)
        {
            TransactionDetail newDetail = TransactionFactory.CreateDetail(TransactionID, StationeryID, Quantity);

            _db.TransactionDetails.Add(newDetail);
            _db.SaveChanges();
        }

        public static List<TransactionHeader> GetUserTransaction(int UserID)
        {
            List<TransactionHeader> AllTransaction = _db.TransactionHeaders.Where(x=> x.UserID == UserID).ToList();

            if (AllTransaction.Count == 0) { return null; }

            return AllTransaction;
        }
    }
}