#pragma checksum "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\Product-app\App\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "256623f26e2852fc6c48e78a91730a94fb81b43c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\Product-app\App\Views\_ViewImports.cshtml"
using App;

#line default
#line hidden
#line 2 "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\Product-app\App\Views\_ViewImports.cshtml"
using App.Models;

#line default
#line hidden
#line 3 "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\Product-app\App\Views\_ViewImports.cshtml"
using BusinessLayer.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\Product-app\App\Views\_ViewImports.cshtml"
using DataLayer.Enums;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"256623f26e2852fc6c48e78a91730a94fb81b43c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e356771bf2b83c457189c5c727dadca2fbe2ded", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\Product-app\App\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Products";

#line default
#line hidden
            BeginContext(68, 34, true);
            WriteLiteral("\r\n<h1>List of Products:</h1>\r\n\r\n\r\n");
            EndContext();
#line 10 "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\Product-app\App\Views\Home\Index.cshtml"
 if (ViewBag.Message != null)
{

#line default
#line hidden
            BeginContext(136, 47, true);
            WriteLiteral("    <div class=\"alert alert-success\">\r\n        ");
            EndContext();
            BeginContext(184, 15, false);
#line 13 "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\Product-app\App\Views\Home\Index.cshtml"
   Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(199, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 15 "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\Product-app\App\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(216, 103, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <h3>Total number of products in the Mall is: ");
            EndContext();
            BeginContext(320, 27, false);
#line 19 "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\Product-app\App\Views\Home\Index.cshtml"
                                                Write(Model.TotalNumberOfProducts);

#line default
#line hidden
            EndContext();
            BeginContext(347, 52, true);
            WriteLiteral("</h3>\r\n\r\n        <ul style=\"list-style-type:none\">\r\n");
            EndContext();
#line 22 "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\Product-app\App\Views\Home\Index.cshtml"
             foreach (ProductVM product in Model.Products)
            {

#line default
#line hidden
            BeginContext(474, 49, true);
            WriteLiteral("                <li>\r\n                    <h4>ID:");
            EndContext();
            BeginContext(524, 10, false);
#line 25 "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\Product-app\App\Views\Home\Index.cshtml"
                      Write(product.Id);

#line default
#line hidden
            EndContext();
            BeginContext(534, 31, true);
            WriteLiteral("</h4>\r\n                    <h4>");
            EndContext();
            BeginContext(566, 19, false);
#line 26 "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\Product-app\App\Views\Home\Index.cshtml"
                   Write(product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(585, 27, true);
            WriteLiteral("</h4>\r\n                    ");
            EndContext();
            BeginContext(612, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4116e898f2dc41c49f4a3b693795c0bb", async() => {
                BeginContext(716, 28, true);
                WriteLiteral("Click here for more details!");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 27 "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\Product-app\App\Views\Home\Index.cshtml"
                                                                              WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(748, 25, true);
            WriteLiteral("\r\n                </li>\r\n");
            EndContext();
#line 29 "C:\Users\dushk\OneDrive\Desktop\SEAVUS\7.ASP.NET Core MVC\Product-app\App\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(788, 33, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
