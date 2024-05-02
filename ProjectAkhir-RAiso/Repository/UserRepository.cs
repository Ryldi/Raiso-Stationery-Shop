﻿using ProjectAkhir_RAiso.Factory;
using ProjectAkhir_RAiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAkhir_RAiso.Repository
{
    public class UserRepository
    {
        private static StationeryDBEntities _db = DatabaseSingleton.GetInstance();

        public static User findUserByName (string name)
        {
            if (_db.Users == null) return null;

            User user = _db.Users.Where(x=> x.UserName == name).FirstOrDefault();

            if(user == null) { return null; } 
            
            return user;
        }

        public static User findRegisteredUser(string name, string password)
        {
            if (_db.Users == null) return null;

            User user = _db.Users.Where(x => x.UserName == name && x.UserPassword == password).FirstOrDefault();

            if (user == null) { return null; }

            return user;
        }

        public static void insertNewCustomer(string name, string DOB, string gender, string address, string phone, string password)
        {
            User newUser = UserFactory.CreateCustomer(name, DOB, gender, address, phone, password);
            if(newUser == null) { return; }

            _db.Users.Add(newUser);
            _db.SaveChanges();

        }

        public static int newID()
        {
            User LastUser = _db.Users.ToList().LastOrDefault();
            if (LastUser == null) return 1;
            return LastUser.UserID + 1;
        }
    }
}