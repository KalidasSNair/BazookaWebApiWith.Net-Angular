using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApp.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }



        [Display(Name ="Account")]
        public virtual int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual Account Accounts { get; set; }



        [Display(Name = "Product")]
        public virtual int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Products { get; set; }

    }
}
