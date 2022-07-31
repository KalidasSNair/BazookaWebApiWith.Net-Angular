using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApp.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Column(TypeName="varchar(20)")]
        
        public string ProductName { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string PictureUrl { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Brand { get; set; }

    }
}
