using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;
using WebApplication6.Controllers;

namespace WebApplication6.Controllers
{
    public class UserpageController : Controller
    {
        // GET: Userpage
        public ActionResult userPage(User U)
        {
            if (U == null)
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

            return View(U);
        }

    }
}