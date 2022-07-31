using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApp.Models
{
    public class Login
    {
        [Key]
        [Required]
        public string EmailId { get; set; }
        [Required]
        public string Password { get; set; }
        
    }
}
