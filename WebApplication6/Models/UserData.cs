using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Controllers;

namespace WebApplication6.Models
{
    public class UserData
    {
        public IEnumerable<User> Users { get; set; } 
    }
}