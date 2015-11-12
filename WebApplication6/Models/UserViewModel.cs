namespace WebApplication6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class UserViewModel
    {
        public int UserID { get; set; }

        [Required(ErrorMessage = "Provide a Username", AllowEmptyStrings = false)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Provide a Password", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Password must be at least 8 character long.")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Confirm Password does not match Password.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please Provide First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Provide Last Name")]
        public string LastName { get; set; }

        [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(selu.edu)$" , ErrorMessage = "Please provide valid email id")]
        public string EmailID { get; set; }




    }
}
