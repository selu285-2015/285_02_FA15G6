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
using System.Web.Helpers;
using System.Net.Mail;
using System.Net;
<<<<<<< HEAD
<<<<<<< HEAD
using System.Security.Cryptography;
=======
>>>>>>> origin/Aaron
=======
using System.Security.Cryptography;
>>>>>>> refs/remotes/origin/master

namespace WebApplication6.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        DataBaseEntities db = new DataBaseEntities();

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Login()
        {
<<<<<<< HEAD
            return View();
        }

        public ActionResult confirmEmail()
        {

            return View();
        }

        public ActionResult confirm(object sender , EventArgs e )
        {
            //U.active = true;
            return RedirectToAction("userPage", "Userpage");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User U)
        {
            if (ModelState.IsValid)
            {
<<<<<<< HEAD
=======
            return View();
        }

        public ActionResult confirmEmail()
        {

            return View();
        }

        public ActionResult confirm(object sender , EventArgs e )
        {
            //U.active = true;
            return RedirectToAction("userPage", "Userpage");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User U)
        {
            if (ModelState.IsValid)
            {
>>>>>>> refs/remotes/origin/master

                using (DataBaseEntities db = new DataBaseEntities())
                {

                    

                    //U.salt = crypto.generatesalt();
                    //U.password += U.salt;
                    //U.password = crypto.hashpassword(U.password);

                    //db.users.add(U);
                    //db.savechanges();
                    //modelstate.clear();

<<<<<<< HEAD
=======
                using (DataBaseEntities db = new DataBaseEntities())
                {
                    //u.salt = crypto.generatesalt();
                    //u.password += u.salt;
                    //u.password = crypto.hashpassword(u.password);

                    //db.users.add(u);
                    //db.savechanges();
                    //modelstate.clear();
                    //
>>>>>>> origin/Aaron
=======
>>>>>>> refs/remotes/origin/master
                    MailMessage m = new MailMessage();
                    SmtpClient sc = new SmtpClient();
                    try
                    {
                        m.From = new MailAddress("selugroup6.maneattraction@gmail.com");
                        m.To.Add(U.EmailID);
                        m.Subject = "Confirm";
                        m.IsBodyHtml = true;
<<<<<<< HEAD
<<<<<<< HEAD
                        m.Body = "Click http://localhost:53460/Account/confirmemail finish registration!";
=======
                        m.Body = "Click http://localhost:53460/Userpage/userPage to finish registration!";
>>>>>>> origin/Aaron
=======
                        m.Body = "Click http://localhost:53460/Account/confirmemail finish registration!";
>>>>>>> refs/remotes/origin/master
                        sc.Host = "smtp.gmail.com";
                        sc.Port = 587;
                        sc.Credentials = new System.Net.NetworkCredential("selugroup6.maneattraction@gmail.com", "burrisislove");

                        sc.EnableSsl = true;
                        sc.Send(m);
<<<<<<< HEAD
<<<<<<< HEAD
=======
                        Response.Write("Email Send successfully");
>>>>>>> origin/Aaron
=======
>>>>>>> refs/remotes/origin/master
                    }
                    catch (Exception ex)
                    {
                        Response.Write(ex.Message);
                    }
                    
                    //
<<<<<<< HEAD
<<<<<<< HEAD
                    
=======

>>>>>>> origin/Aaron
=======
                    
>>>>>>> refs/remotes/origin/master
                    U = null;
                    ViewBag.Message = "Registration Done";
                }
            }
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> refs/remotes/origin/master
            return RedirectToAction("Index" , "Home");
        }

        [HttpPost]
        public int ConfirmEmail(User U)
        {
            return U.Active = 1;
        }
<<<<<<< HEAD
=======
            return RedirectToAction("Home" , "Index");
        }

>>>>>>> origin/Aaron

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            User validate = db.Users.FirstOrDefault(dbUsers => dbUsers.UserName == username);
            if (validate != null)
            {
<<<<<<< HEAD
                if (Crypto.VerifyHashedPassword(validate.Password, password + validate.Salt))
                {

                    return RedirectToAction("Home", "Index");

                }
            }
            return RedirectToAction("Create");
=======
  //              if (Crypto.VerifyHashedPassword(validate.Password, password + validate.Salt))
                {
                }
            }
            return RedirectToAction("userPage");
>>>>>>> origin/Aaron
=======

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            User validate = db.Users.FirstOrDefault(dbUsers => dbUsers.UserName == username);
            if (validate != null)
            {
                if (Crypto.VerifyHashedPassword(validate.Password, password + validate.Salt))
                {

                    return RedirectToAction("Home", "Index");

                }
            }
            return RedirectToAction("Create");
>>>>>>> refs/remotes/origin/master
        }

    }
}