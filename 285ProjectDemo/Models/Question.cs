

namespace _285ProjectDemo.Models
{
    public class QuestionModel
    {
        public int ID { get; set; }
        public string Question {get; set;}
        public int CategoryID { get; set; }
        public virtual QuestionCategory QuestionCategory { get; set; }

    }
}