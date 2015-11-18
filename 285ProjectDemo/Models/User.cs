using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace _285ProjectDemo.Models
{
    public class User
    {   
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public List<Gender> InterestedIn { get; set; }
        public Classification Classification { get; set; }
        public Major Major { get; set; }
        public  string Username { get; set; }
        [DataType("Password")]
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Email { get; set; }
        public List<UserAnswers> Questionair { get; set; } 
        
        
    }
    
    
    public enum Classification
    {
        Freshman, Sophomore, Junior, Senior, Graduate, FurthuringEducation, Alumni, Professor
    }
      
    public enum Gender
    {
        Male,Female,TransMale,TransFemale,Heat,Missle,AssultHelecopter
    }
}