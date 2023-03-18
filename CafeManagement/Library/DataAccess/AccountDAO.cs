﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;
namespace Library.DataAccess
{
    public class AccountDAO
    {

        private static AccountDAO instance = null;
        private static readonly object instancelock = new object();
        private AccountDAO() { }
        public static AccountDAO Instance
        {
            get
            {
                lock (instancelock)
                {
                    if (instance == null)
                    {
                        instance = new AccountDAO();
                    }
                    return instance;
                }
            }
        }

        public Account checkLogin(string username, string password)
        {
            using (var db = new CoffeeShopManagementContext())
            {
                return db.Accounts.Where(m => m.Username.Equals(username) && m.Password.Equals(password)).FirstOrDefault();
            }
        }
    }
}
