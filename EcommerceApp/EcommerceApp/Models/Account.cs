using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApp.Models
{
    public class Account
    {
        [Key]
        public int UserId { get; set; }
        [Column(TypeName ="varchar(100)")]
        public string FirstName { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string LastName { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Password { get; set; }

    }
}
