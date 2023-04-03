namespace PetShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long UID { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsAdmin { get; set; }

        public bool? IsMod { get; set; }
    }
}
