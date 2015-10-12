using System.Collections.Generic;
using _285ProjectDemo.Migrations;
using _285ProjectDemo.Models;


namespace _285ProjectDemo.ViewModels
{
    public class Questionaire
    {
        public List<QuestionModel> Questions {get; set;}
        public string category { get; set; }
    }
}