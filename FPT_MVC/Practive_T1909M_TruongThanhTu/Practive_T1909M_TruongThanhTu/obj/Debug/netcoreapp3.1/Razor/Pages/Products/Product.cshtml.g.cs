#pragma checksum "D:\Profile\CSharp\CShaprt\FPT_MVC\Practive_T1909M_TruongThanhTu\Practive_T1909M_TruongThanhTu\Pages\Products\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18fe094b80edb610187326cef8d3da22abec5240"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Practive_T1909M_TruongThanhTu.Pages.Products.Pages_Products_Product), @"mvc.1.0.razor-page", @"/Pages/Products/Product.cshtml")]
namespace Practive_T1909M_TruongThanhTu.Pages.Products
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Profile\CSharp\CShaprt\FPT_MVC\Practive_T1909M_TruongThanhTu\Practive_T1909M_TruongThanhTu\Pages\_ViewImports.cshtml"
using Practive_T1909M_TruongThanhTu;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18fe094b80edb610187326cef8d3da22abec5240", @"/Pages/Products/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecc5b9f942a2236811f892ec2b568ed70c495159", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Products_Product : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Profile\CSharp\CShaprt\FPT_MVC\Practive_T1909M_TruongThanhTu\Practive_T1909M_TruongThanhTu\Pages\Products\Product.cshtml"
  
    ViewData["Title"] = "Product page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card-title text-center font-weight-bold\" style=\"font-size:23px\">My ProductManage</div>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 8 "D:\Profile\CSharp\CShaprt\FPT_MVC\Practive_T1909M_TruongThanhTu\Practive_T1909M_TruongThanhTu\Pages\Products\Product.cshtml"
     foreach (var product in Model.Products)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-3 col-sm-6 col-12\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 357, "\"", 377, 1);
#nullable restore
#line 11 "D:\Profile\CSharp\CShaprt\FPT_MVC\Practive_T1909M_TruongThanhTu\Practive_T1909M_TruongThanhTu\Pages\Products\Product.cshtml"
WriteAttributeValue("", 363, product.Image, 363, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"hihi\" style=\"height:300px\">\r\n            <h3 style=\"font-size:16px\" class=\"mt-2\">");
#nullable restore
#line 12 "D:\Profile\CSharp\CShaprt\FPT_MVC\Practive_T1909M_TruongThanhTu\Practive_T1909M_TruongThanhTu\Pages\Products\Product.cshtml"
                                               Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <p>");
#nullable restore
#line 13 "D:\Profile\CSharp\CShaprt\FPT_MVC\Practive_T1909M_TruongThanhTu\Practive_T1909M_TruongThanhTu\Pages\Products\Product.cshtml"
          Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</p>\r\n        </div>\r\n");
#nullable restore
#line 15 "D:\Profile\CSharp\CShaprt\FPT_MVC\Practive_T1909M_TruongThanhTu\Practive_T1909M_TruongThanhTu\Pages\Products\Product.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Practive_T1909M_TruongThanhTu.Pages.Products.ProductModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Practive_T1909M_TruongThanhTu.Pages.Products.ProductModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Practive_T1909M_TruongThanhTu.Pages.Products.ProductModel>)PageContext?.ViewData;
        public Practive_T1909M_TruongThanhTu.Pages.Products.ProductModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
