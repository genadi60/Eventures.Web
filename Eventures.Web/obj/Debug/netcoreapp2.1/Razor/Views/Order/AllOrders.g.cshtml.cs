#pragma checksum "C:\Users\genad\OneDrive\Работен плот\ASP.NET Core\Eventures.Web\Eventures.Web\Views\Order\AllOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "789b4bfba682abfec4d57f4f23a4d8710f2c9041"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_AllOrders), @"mvc.1.0.view", @"/Views/Order/AllOrders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/AllOrders.cshtml", typeof(AspNetCore.Views_Order_AllOrders))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\genad\OneDrive\Работен плот\ASP.NET Core\Eventures.Web\Eventures.Web\Views\_ViewImports.cshtml"
using Eventures.Web;

#line default
#line hidden
#line 2 "C:\Users\genad\OneDrive\Работен плот\ASP.NET Core\Eventures.Web\Eventures.Web\Views\_ViewImports.cshtml"
using Eventures.Models;

#line default
#line hidden
#line 3 "C:\Users\genad\OneDrive\Работен плот\ASP.NET Core\Eventures.Web\Eventures.Web\Views\_ViewImports.cshtml"
using Eventures.Web.Services;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"789b4bfba682abfec4d57f4f23a4d8710f2c9041", @"/Views/Order/AllOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b60991d7df56a42d5b5bb3d21e1b9a575ea0027", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_AllOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Eventures.Web.ViewModels.AllOrdersViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\genad\OneDrive\Работен плот\ASP.NET Core\Eventures.Web\Eventures.Web\Views\Order\AllOrders.cshtml"
  
    ViewData["Title"] = "All Orders";

#line default
#line hidden
            BeginContext(98, 70, true);
            WriteLiteral("<div class=\"container\">\r\n    <h2 class=\"text-center font-weight-bold\">");
            EndContext();
            BeginContext(169, 17, false);
#line 6 "C:\Users\genad\OneDrive\Работен плот\ASP.NET Core\Eventures.Web\Eventures.Web\Views\Order\AllOrders.cshtml"
                                        Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(186, 327, true);
            WriteLiteral(@"</h2>
    <hr class=""hr-4-eventures"" />
    <div class=""row"">
        <div class=""col col-1 font-weight-bold"">#</div>
        <div class=""col col-4 font-weight-bold"">Event</div>
        <div class=""col col-3 font-weight-bold"">Customer</div>
        <div class=""col col-4 font-weight-bold"">Ordered On</div>
    </div>

");
            EndContext();
#line 15 "C:\Users\genad\OneDrive\Работен плот\ASP.NET Core\Eventures.Web\Eventures.Web\Views\Order\AllOrders.cshtml"
       var number = 1;

#line default
#line hidden
            BeginContext(538, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 16 "C:\Users\genad\OneDrive\Работен плот\ASP.NET Core\Eventures.Web\Eventures.Web\Views\Order\AllOrders.cshtml"
     foreach (var orderModel in Model.Orders)
    {

#line default
#line hidden
            BeginContext(592, 95, true);
            WriteLiteral("        <hr />\r\n        <div class=\"row\">\r\n            <div class=\"col col-1 font-weight-bold\">");
            EndContext();
            BeginContext(688, 6, false);
#line 20 "C:\Users\genad\OneDrive\Работен плот\ASP.NET Core\Eventures.Web\Eventures.Web\Views\Order\AllOrders.cshtml"
                                               Write(number);

#line default
#line hidden
            EndContext();
            BeginContext(694, 43, true);
            WriteLiteral("</div>\r\n            <div class=\"col col-4\">");
            EndContext();
            BeginContext(738, 20, false);
#line 21 "C:\Users\genad\OneDrive\Работен плот\ASP.NET Core\Eventures.Web\Eventures.Web\Views\Order\AllOrders.cshtml"
                              Write(orderModel.EventName);

#line default
#line hidden
            EndContext();
            BeginContext(758, 43, true);
            WriteLiteral("</div>\r\n            <div class=\"col col-3\">");
            EndContext();
            BeginContext(802, 23, false);
#line 22 "C:\Users\genad\OneDrive\Работен плот\ASP.NET Core\Eventures.Web\Eventures.Web\Views\Order\AllOrders.cshtml"
                              Write(orderModel.CustomerName);

#line default
#line hidden
            EndContext();
            BeginContext(825, 43, true);
            WriteLiteral("</div>\r\n            <div class=\"col col-4\">");
            EndContext();
            BeginContext(869, 20, false);
#line 23 "C:\Users\genad\OneDrive\Работен плот\ASP.NET Core\Eventures.Web\Eventures.Web\Views\Order\AllOrders.cshtml"
                              Write(orderModel.OrderedOn);

#line default
#line hidden
            EndContext();
            BeginContext(889, 24, true);
            WriteLiteral("</div>\r\n        </div>\r\n");
            EndContext();
#line 25 "C:\Users\genad\OneDrive\Работен плот\ASP.NET Core\Eventures.Web\Eventures.Web\Views\Order\AllOrders.cshtml"
        number++;
    }

#line default
#line hidden
            BeginContext(939, 41, true);
            WriteLiteral("    <hr class=\"hr-4-eventures\" />\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Eventures.Web.ViewModels.AllOrdersViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
