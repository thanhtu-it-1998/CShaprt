using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Practive_T1909M_TruongThanhTu.Models
{
    public class Product
    {
        public  int ID { get; set; }

        public string Name { get; set; }
        
        public string Price { get; set; }
        
        public string Image { get; set; }

    }
}
