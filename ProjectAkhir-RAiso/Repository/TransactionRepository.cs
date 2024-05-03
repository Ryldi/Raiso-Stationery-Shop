﻿using ProjectAkhir_RAiso.Factory;
using ProjectAkhir_RAiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Util;

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

        public static List<TransactionDetail> GetTransactionDetail(int TransactionID)
        {
            List<TransactionDetail> AllDetail = _db.TransactionDetails.Where(x => x.TransactionID == TransactionID).ToList();

            if (AllDetail.Count == 0) { return null; }

            return AllDetail;
        }

        public static bool FindItemInTransaction(int ItemID)
        {
            TransactionDetail Detail = _db.TransactionDetails.Where(x=> x.StationeryID == ItemID).FirstOrDefault();

            if (Detail == null) { return false; }

            return true;
        }
    }
}