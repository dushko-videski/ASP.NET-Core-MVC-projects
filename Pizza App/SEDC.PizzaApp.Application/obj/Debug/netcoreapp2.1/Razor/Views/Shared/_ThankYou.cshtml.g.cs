#pragma checksum "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\SEDC.PizzaApp\SEDC.PizzaApp.Application\Views\Shared\_ThankYou.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fad4ce440bd02a038991dacb7f3459d5d784f03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ThankYou), @"mvc.1.0.view", @"/Views/Shared/_ThankYou.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ThankYou.cshtml", typeof(AspNetCore.Views_Shared__ThankYou))]
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
#line 1 "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\SEDC.PizzaApp\SEDC.PizzaApp.Application\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Application;

#line default
#line hidden
#line 2 "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\SEDC.PizzaApp\SEDC.PizzaApp.Application\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Application.Models;

#line default
#line hidden
#line 3 "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\SEDC.PizzaApp\SEDC.PizzaApp.Application\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.BusinessModels.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fad4ce440bd02a038991dacb7f3459d5d784f03", @"/Views/Shared/_ThankYou.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b79a47711d1b51a7f615b5a570f10f3b0a2334c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ThankYou : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\SEDC.PizzaApp\SEDC.PizzaApp.Application\Views\Shared\_ThankYou.cshtml"
   ViewBag.Title = "Thank You"; 

#line default
#line hidden
            BeginContext(35, 183, true);
            WriteLiteral("<div class=\"jumbotron\">\r\n    <h1>Thank you for ordering</h1>\r\n    <p>Order again or leave us a feedback so we can improve!</p>\r\n    <p>\r\n        <button class=\"btn btn-danger btn-lg\">");
            EndContext();
            BeginContext(219, 47, false);
#line 6 "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\SEDC.PizzaApp\SEDC.PizzaApp.Application\Views\Shared\_ThankYou.cshtml"
                                         Write(Html.ActionLink("Feedback", "Feedback", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(266, 27, true);
            WriteLiteral("</button>\r\n    </p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591