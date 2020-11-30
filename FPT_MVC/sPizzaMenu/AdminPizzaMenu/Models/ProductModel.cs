using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPizzaMenu.Models
{
    public class ProductModel
    {
        [Key]
        public int ProductId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string ProductName { get; set; }

        [Column(TypeName = "nvarchar(300)")]

        public string Description { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string ImageName { get; set; }

    }
}
