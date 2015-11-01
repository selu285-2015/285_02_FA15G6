namespace WebApplication6
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using WebApplication6.Controllers;

    public partial class UsersContext : DbContext
    {
        public UsersContext() : base("name=UserContext")
        {
        }

        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
