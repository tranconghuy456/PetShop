namespace PetShop.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public partial class AccountModels : DbContext
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public AccountModels()
            : base("name=AccountModels")
        {

        }

        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
