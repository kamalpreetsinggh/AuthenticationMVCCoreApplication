using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationMVCApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationMVCApplication
{
    public class Login:DbContext
    {
        public DbSet<UserProfile> ApplicationLoginTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source=192.168.12.20;Initial Catalog=training2018;Persist Security Info=True;User ID=usr_2018;Password=pwd@123");
        }
    }
}
