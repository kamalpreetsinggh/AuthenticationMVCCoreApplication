using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationMVCApplication.DAL;
using AuthenticationMVCApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationMVCApplication.Controllers
{
    public class DetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginCredentials login)
        {
            DBOperations dbOperations = new DBOperations();
            var users = dbOperations.GetUsers().FirstOrDefault(x => x.Username == login.Username && x.Password == login.Password);

            return users != null ? RedirectToAction("Dashboard", users) : RedirectToAction("Index");
        }

        public IActionResult Dashboard(UserProfile userProfile)
        {
            return View(userProfile);
        }
    }
}