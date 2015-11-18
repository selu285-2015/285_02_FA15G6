using System;
using System.ComponentModel.DataAnnotations;


namespace _285ProjectDemo.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Major Major { get; set; }
        //public Classification Classification { get; set; }
        public int Age { get; set; }
        //public Orientation Orientation { get; set; }
        public  string Username { get; set; }
        [DataType("Password")]
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Email { get; set; }
        
    }
    public enum Major{
        Biology,Business,Chemistry,Communications,ComputerScience,Education,History,IndustrialTechnology,Kinesiology,Mathematics,Music,Nursing,Physics,PoliticalScience,Psychology,Sociology
 
    }

    //public enum Classification
    //{
    //    Freshman, Sophomore, Junior, Senior, Graduate, ReturningStudent
    //}

    //public enum Orientation
    //{
    //    Male,Female,Bisexual,Pansexual,AssultHelicopter,Marine
    //}
}