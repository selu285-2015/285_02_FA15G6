using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _285ProjectDemo.Models
{
    public class UserAnswers
    {   
        public int ID  { get; set; }
        public QuestionModel Question { get; set; }
        public int Answer { get; set; }
    }
}