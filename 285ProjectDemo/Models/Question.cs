

using System;
using System.ComponentModel.DataAnnotations;

namespace _285ProjectDemo.Models
{
    public class QuestionModel
    {
        [Key]
        public int ID { get; set; }
        public string Title {get; set;}
        public Category Category { get; set; }

    }
    public enum Category
    {
        Personality, Hobbies, LifeStyle
    }
}