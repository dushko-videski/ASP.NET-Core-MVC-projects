#pragma checksum "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\SEDC.PizzaApp\SEDC.PizzaApp.Application\Views\Home\Feedback.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61472df1c18d141b75de12449dbcdc8cfc7968ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Feedback), @"mvc.1.0.view", @"/Views/Home/Feedback.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Feedback.cshtml", typeof(AspNetCore.Views_Home_Feedback))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61472df1c18d141b75de12449dbcdc8cfc7968ec", @"/Views/Home/Feedback.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b79a47711d1b51a7f615b5a570f10f3b0a2334c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Feedback : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FeedbackViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\SEDC.PizzaApp\SEDC.PizzaApp.Application\Views\Home\Feedback.cshtml"
  
    ViewBag.Title = "Feedback";

#line default
#line hidden
            BeginContext(66, 24, true);
            WriteLiteral("<h1>Order pizza</h1>\r\n\r\n");
            EndContext();
#line 7 "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\SEDC.PizzaApp\SEDC.PizzaApp.Application\Views\Home\Feedback.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(120, 157, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <div class=\"input-group input-group-md\">\r\n                <span class=\"input-group-addon\">");
            EndContext();
            BeginContext(278, 26, false);
#line 12 "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\SEDC.PizzaApp\SEDC.PizzaApp.Application\Views\Home\Feedback.cshtml"
                                           Write(Html.LabelFor(x => x.Name));

#line default
#line hidden
            EndContext();
            BeginContext(304, 25, true);
            WriteLiteral("</span>\r\n                ");
            EndContext();
            BeginContext(330, 61, false);
#line 13 "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\SEDC.PizzaApp\SEDC.PizzaApp.Application\Views\Home\Feedback.cshtml"
           Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(391, 172, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <div class=\"input-group input-group-md\">\r\n                <span class=\"input-group-addon\">");
            EndContext();
            BeginContext(564, 27, false);
#line 18 "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\SEDC.PizzaApp\SEDC.PizzaApp.Application\Views\Home\Feedback.cshtml"
                                           Write(Html.LabelFor(x => x.Email));

#line default
#line hidden
            EndContext();
            BeginContext(591, 25, true);
            WriteLiteral("</span>\r\n                ");
            EndContext();
            BeginContext(617, 62, false);
#line 19 "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\SEDC.PizzaApp\SEDC.PizzaApp.Application\Views\Home\Feedback.cshtml"
           Write(Html.TextBoxFor(x => x.Email, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(679, 124, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <span>");
            EndContext();
            BeginContext(804, 29, false);
#line 25 "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\SEDC.PizzaApp\SEDC.PizzaApp.Application\Views\Home\Feedback.cshtml"
             Write(Html.LabelFor(x => x.Message));

#line default
#line hidden
            EndContext();
            BeginContext(833, 21, true);
            WriteLiteral("</span>\r\n            ");
            EndContext();
            BeginContext(855, 32, false);
#line 26 "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\SEDC.PizzaApp\SEDC.PizzaApp.Application\Views\Home\Feedback.cshtml"
       Write(Html.TextAreaFor(x => x.Message));

#line default
#line hidden
            EndContext();
            BeginContext(887, 96, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <button class=\"btn btn-danger\" type=\"submit\">Submit</button>\r\n");
            EndContext();
#line 30 "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\SEDC.PizzaApp\SEDC.PizzaApp.Application\Views\Home\Feedback.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FeedbackViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
