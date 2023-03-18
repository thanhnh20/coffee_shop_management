using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    public class StaffDAO
    {
        private static StaffDAO instance = null;
        private static readonly object instancelock = new object();
        private StaffDAO() { }
        public static StaffDAO Instance
        {
            get
            {
                lock (instancelock)
                {
                    if (instance == null)
                    {
                        instance = new StaffDAO();
                    }
                    return instance;
                }
            }
        }

        public staff getStaffByUserName(string username)
        {
            using (var db = new CoffeeShopManagementContext())
            {
                return db.staff.Where(s => s.Username.Equals(username)).FirstOrDefault();
            }
        }
    }
}
