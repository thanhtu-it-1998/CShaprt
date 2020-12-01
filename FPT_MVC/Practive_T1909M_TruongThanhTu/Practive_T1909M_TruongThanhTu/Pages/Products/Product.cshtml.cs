using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Practive_T1909M_TruongThanhTu.Models;
using Practive_T1909M_TruongThanhTu.Services;

namespace Practive_T1909M_TruongThanhTu.Pages.Products
{
    public class ProductModel : PageModel
    {
        public readonly ILogger<ProductModel> _logger;
        public ProductServices _productServices;
        public IEnumerable<Product> Products { get; set; }


        public ProductModel(ILogger<ProductModel> logger, ProductServices productServices   ) {
            _logger = logger;
            _productServices = productServices;
        }

        public void OnGet()
        {
            Products = _productServices.GetProducts();
        }
    }
}
