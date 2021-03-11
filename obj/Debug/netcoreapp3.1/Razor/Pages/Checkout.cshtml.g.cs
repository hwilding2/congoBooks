#pragma checksum "C:\Users\haven\Documents\Academics\413\Congo\Pages\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db4a05d93cf5e3b32ebb50d1ff954d5d1e635cea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Congo.Pages.Pages_Checkout), @"mvc.1.0.razor-page", @"/Pages/Checkout.cshtml")]
namespace Congo.Pages
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
#line 2 "C:\Users\haven\Documents\Academics\413\Congo\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\haven\Documents\Academics\413\Congo\Pages\_ViewImports.cshtml"
using Congo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\haven\Documents\Academics\413\Congo\Pages\_ViewImports.cshtml"
using Congo.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db4a05d93cf5e3b32ebb50d1ff954d5d1e635cea", @"/Pages/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"541fd7ffb90c2d35de99be1056084e4acef037de", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Checkout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<p>View Cart</p>\r\n\r\n<table class=\"table table-bordered table-striped\">\r\n\r\n    <thead>\r\n        <tr>\r\n            <th>Item</th><th>Quantity</th><th>Price</th><th>Subtotal</th><th>Remove</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\haven\Documents\Academics\413\Congo\Pages\Checkout.cshtml"
         foreach(var line in Model.Cart.Lines)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"text-left\">");
#nullable restore
#line 20 "C:\Users\haven\Documents\Academics\413\Congo\Pages\Checkout.cshtml"
                                 Write(line.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center\">");
#nullable restore
#line 21 "C:\Users\haven\Documents\Academics\413\Congo\Pages\Checkout.cshtml"
                                   Write(line.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-right\">$");
#nullable restore
#line 22 "C:\Users\haven\Documents\Academics\413\Congo\Pages\Checkout.cshtml"
                                   Write(line.Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-right\">");
#nullable restore
#line 23 "C:\Users\haven\Documents\Academics\413\Congo\Pages\Checkout.cshtml"
                                   Write((line.Quantity*line.Book.Price).ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center\">\r\n                    <button type=\"button\" class=\"btn-primary btn-sm pull-right\" style=\"float:right\" onclick=\"RemoveItem(line.Book)\">Remove Item</button> ");
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "C:\Users\haven\Documents\Academics\413\Congo\Pages\Checkout.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td class=\"text-right\" colspan=\"3\">Total:</td>\r\n            <td class=\"text-right\">");
#nullable restore
#line 33 "C:\Users\haven\Documents\Academics\413\Congo\Pages\Checkout.cshtml"
                              Write(Model.Cart.ComputeTotal().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n\r\n<div class=\"text-center\">\r\n    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1209, "\"", 1232, 1);
#nullable restore
#line 39 "C:\Users\haven\Documents\Academics\413\Congo\Pages\Checkout.cshtml"
WriteAttributeValue("", 1216, Model.ReturnUrl, 1216, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Continue Shopping</a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Congo.Pages.CheckoutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Congo.Pages.CheckoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Congo.Pages.CheckoutModel>)PageContext?.ViewData;
        public Congo.Pages.CheckoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591