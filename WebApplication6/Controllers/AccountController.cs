using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User U)
        {
            if (ModelState.IsValid)
            {
                using (DataBaseEntities db = new DataBaseEntities())
                {

                    db.Users.Add(U);    
                    db.SaveChanges();
                    ModelState.Clear();
                    U = null;
                    ViewBag.Message = "Registration Done";
                }
            }
            return RedirectToAction("userPage" , "Userpage");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User U)
        {
            if (ModelState.IsValid)
            {
                


            }
            return View(U);
        }

    }
}