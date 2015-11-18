using _285ProjectDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _285ProjectDemo
{
    public class DataContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<UserAnswers> UserAnswerses { get; set; }
        public DbSet<Major> Major { get; set; }
        public DbSet<Concentration> Concentration { get; set; }
    }
}