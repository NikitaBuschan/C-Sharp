#pragma checksum "E:\web\02-Backend\ASP.NET\04-Products(Model)\04-Products(Model)\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f32630deb0670205cba917c18eafe83471073007"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "E:\web\02-Backend\ASP.NET\04-Products(Model)\04-Products(Model)\Views\_ViewImports.cshtml"
using _04_Products_Model_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\web\02-Backend\ASP.NET\04-Products(Model)\04-Products(Model)\Views\Home\Index.cshtml"
using _04_Products_Model_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f32630deb0670205cba917c18eafe83471073007", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2388024d4da179feb74f1651b965256c1ffcd561", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Home.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f32630deb0670205cba917c18eafe834710730073840", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "E:\web\02-Backend\ASP.NET\04-Products(Model)\04-Products(Model)\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>List:</h3>\r\n<div class=\"list\">\r\n");
#nullable restore
#line 12 "E:\web\02-Backend\ASP.NET\04-Products(Model)\04-Products(Model)\Views\Home\Index.cshtml"
     foreach (var item in @Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\web\02-Backend\ASP.NET\04-Products(Model)\04-Products(Model)\Views\Home\Index.cshtml"
   Write(item.CreateList());

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\web\02-Backend\ASP.NET\04-Products(Model)\04-Products(Model)\Views\Home\Index.cshtml"
                          ;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<h3>Table:</h3>\r\n");
#nullable restore
#line 19 "E:\web\02-Backend\ASP.NET\04-Products(Model)\04-Products(Model)\Views\Home\Index.cshtml"
  
    List<string> columns = new List<string>() { "Id", "Name", "Cost", "Create date" };

#line default
#line hidden
#nullable disable
            WriteLiteral("<table>\r\n    <tr>\r\n");
#nullable restore
#line 24 "E:\web\02-Backend\ASP.NET\04-Products(Model)\04-Products(Model)\Views\Home\Index.cshtml"
         foreach (var column in columns)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th>");
#nullable restore
#line 26 "E:\web\02-Backend\ASP.NET\04-Products(Model)\04-Products(Model)\Views\Home\Index.cshtml"
           Write(column);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 27 "E:\web\02-Backend\ASP.NET\04-Products(Model)\04-Products(Model)\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\r\n");
#nullable restore
#line 29 "E:\web\02-Backend\ASP.NET\04-Products(Model)\04-Products(Model)\Views\Home\Index.cshtml"
     foreach (var item in @Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "E:\web\02-Backend\ASP.NET\04-Products(Model)\04-Products(Model)\Views\Home\Index.cshtml"
   Write(item.CreateTableRow());

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "E:\web\02-Backend\ASP.NET\04-Products(Model)\04-Products(Model)\Views\Home\Index.cshtml"
                              ;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591