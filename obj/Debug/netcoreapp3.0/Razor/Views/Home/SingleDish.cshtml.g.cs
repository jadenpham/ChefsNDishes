#pragma checksum "C:\Users\Owner\Desktop\coding\csharp\aspMVC\ChefsNDishes\Views\Home\SingleDish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec18a0c9e1a2d8e750fdd30b897a0c41671c75a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SingleDish), @"mvc.1.0.view", @"/Views/Home/SingleDish.cshtml")]
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
#line 1 "C:\Users\Owner\Desktop\coding\csharp\aspMVC\ChefsNDishes\Views\_ViewImports.cshtml"
using ChefsNDishes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Owner\Desktop\coding\csharp\aspMVC\ChefsNDishes\Views\Home\SingleDish.cshtml"
using ChefsNDishes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec18a0c9e1a2d8e750fdd30b897a0c41671c75a6", @"/Views/Home/SingleDish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3683dbd783bea45b88d0b0d3ee52e8ec1e5d61", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SingleDish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec18a0c9e1a2d8e750fdd30b897a0c41671c75a63284", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Document</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec18a0c9e1a2d8e750fdd30b897a0c41671c75a64395", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("    <div>\r\n        <a href=\"/\">Home</a>\r\n        <a href=\"/dishes\">Dishes</a>\r\n        <h1>");
#nullable restore
#line 14 "C:\Users\Owner\Desktop\coding\csharp\aspMVC\ChefsNDishes\Views\Home\SingleDish.cshtml"
       Write(ViewBag.Dish.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n        <h4>Calories: ");
#nullable restore
#line 15 "C:\Users\Owner\Desktop\coding\csharp\aspMVC\ChefsNDishes\Views\Home\SingleDish.cshtml"
                 Write(ViewBag.Dish.Calories);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n        <h4>Tastiness: ");
#nullable restore
#line 16 "C:\Users\Owner\Desktop\coding\csharp\aspMVC\ChefsNDishes\Views\Home\SingleDish.cshtml"
                  Write(ViewBag.Dish.Tastiness);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n        <h4>Description:</h4>\r\n        <p>");
#nullable restore
#line 18 "C:\Users\Owner\Desktop\coding\csharp\aspMVC\ChefsNDishes\Views\Home\SingleDish.cshtml"
      Write(ViewBag.Dish.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <h4>Ingredients</h4>\r\n        <p>");
#nullable restore
#line 20 "C:\Users\Owner\Desktop\coding\csharp\aspMVC\ChefsNDishes\Views\Home\SingleDish.cshtml"
      Write(ViewBag.Dish.Ingredients);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <h4>Instructions:</h4>\r\n        <p>");
#nullable restore
#line 22 "C:\Users\Owner\Desktop\coding\csharp\aspMVC\ChefsNDishes\Views\Home\SingleDish.cshtml"
      Write(ViewBag.Dish.Instructions);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
