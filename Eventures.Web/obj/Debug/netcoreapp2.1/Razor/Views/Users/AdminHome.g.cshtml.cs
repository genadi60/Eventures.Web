#pragma checksum "C:\Users\genad\OneDrive\Работен плот\ASP.NET Core\Eventures.Web\Eventures.Web\Views\Users\AdminHome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c54231ab42027d4902711bf51d0d8da82525677d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_AdminHome), @"mvc.1.0.view", @"/Views/Users/AdminHome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/AdminHome.cshtml", typeof(AspNetCore.Views_Users_AdminHome))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c54231ab42027d4902711bf51d0d8da82525677d", @"/Views/Users/AdminHome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b60991d7df56a42d5b5bb3d21e1b9a575ea0027", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_AdminHome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Eventures.Web.ViewModels.UserViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\genad\OneDrive\Работен плот\ASP.NET Core\Eventures.Web\Eventures.Web\Views\Users\AdminHome.cshtml"
  
    ViewData["Title"] = "Admin Home";

#line default
#line hidden
            BeginContext(93, 162, true);
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"jumbotron eventures-bg-color rounded\">\r\n        <h2 class=\"text-center mt-4 font-weight-bold\">Greetings, Administrator - ");
            EndContext();
            BeginContext(256, 15, false);
#line 7 "C:\Users\genad\OneDrive\Работен плот\ASP.NET Core\Eventures.Web\Eventures.Web\Views\Users\AdminHome.cshtml"
                                                                            Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(271, 155, true);
            WriteLiteral("!</h2>\r\n        <hr class=\"hr-4-braun\" />\r\n        <h4 class=\"text-center nav-link-braun mb-4 font-weight-bold\">Enjoy your work.</h4>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Eventures.Web.ViewModels.UserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
