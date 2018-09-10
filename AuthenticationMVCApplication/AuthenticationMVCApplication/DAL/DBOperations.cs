using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationMVCApplication.DAL;
using AuthenticationMVCApplication.Models;

namespace AuthenticationMVCApplication.DAL
{
    public class DBOperations
    {
        public List<UserProfile> GetUsers()
        {
            using (var login = new Login())
            {
                return login.ApplicationLoginTable.ToList();
            }
        }
    }
}
