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
using System.Security.Cryptography;

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

                using (DataBaseEntities db = new DataBaseEntities())
                {

                    

                    //U.salt = crypto.generatesalt();
                    //U.password += U.salt;
                    //U.password = crypto.hashpassword(U.password);

                    //db.users.add(U);
                    //db.savechanges();
                    //modelstate.clear();

                    MailMessage m = new MailMessage();
                    SmtpClient sc = new SmtpClient();
                    try
                    {
                        m.From = new MailAddress("selugroup6.maneattraction@gmail.com");
                        m.To.Add(U.EmailID);
                        m.Subject = "Confirm";
                        m.IsBodyHtml = true;
                        m.Body = "Click http://localhost:53460/Userpage/userPage to finish registration!";
                        sc.Host = "smtp.gmail.com";
                        sc.Port = 587;
                        sc.Credentials = new System.Net.NetworkCredential("selugroup6.maneattraction@gmail.com", "burrisislove");

                        sc.EnableSsl = true;
                        sc.Send(m);
                    }
                    catch (Exception ex)
                    {
                        Response.Write(ex.Message);
                    }
                    
                    //
                    
                    U = null;
                    ViewBag.Message = "Registration Done";
                }
            }
            return RedirectToAction("Home" , "Index");
        }


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
        }

    }
}