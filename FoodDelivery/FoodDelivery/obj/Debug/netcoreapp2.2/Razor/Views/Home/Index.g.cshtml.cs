#pragma checksum "D:\ITIS\Programms\FoodDelivery\FoodDelivery\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c369b4e3a2a4381ff4481d30da97979a1bf7138"
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
#line 1 "D:\ITIS\Programms\FoodDelivery\FoodDelivery\Views\_ViewImports.cshtml"
using FoodDelivery;

#line default
#line hidden
#line 2 "D:\ITIS\Programms\FoodDelivery\FoodDelivery\Views\_ViewImports.cshtml"
using FoodDelivery.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c369b4e3a2a4381ff4481d30da97979a1bf7138", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b75093ee18a4ac1755d7a2c2ccc07c5e8a70fc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 127, true);
            WriteLiteral("<!DOCTYPE html>\r\n<div class=\"centerWindow\">\r\n    <h1>Welcome to Food Delivery</h1>\r\n    <p>Login to access Food Delivery.</p>\r\n");
            EndContext();
#line 5 "D:\ITIS\Programms\FoodDelivery\FoodDelivery\Views\Home\Index.cshtml"
     using (Html.BeginForm("Login", "User", FormMethod.Post))
    {

#line default
#line hidden
            BeginContext(197, 280, true);
            WriteLiteral(@"        <p><input type=""text"" class=""searchbar"" name=""login"" placeholder=""login"" required /></p>
        <p><input type=""password"" class=""searchbar"" name=""password"" placeholder=""password"" required /></p>
        <p><input type=""submit"" class=""bubbly-button"" value=""Login""></p>
");
            EndContext();
#line 10 "D:\ITIS\Programms\FoodDelivery\FoodDelivery\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(484, 127, true);
            WriteLiteral("    <p><input type=\"button\" class=\"bubbly-button\" value=\"Register\" onclick=\'location.href = \"Home/RegisterPage\"\'></p>\r\n</div>\r\n");
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