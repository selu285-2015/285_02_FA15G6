using System;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using WebApplication6.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace WebApplication6.Models
{
    [Table("User")]
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Provide a Username", AllowEmptyStrings = false)]
        public string UserName { get; }

        [Required(ErrorMessage = "Provide a Password", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Password must be at least 8 character long.")]
        public string Password { get; }

    }

    














}
