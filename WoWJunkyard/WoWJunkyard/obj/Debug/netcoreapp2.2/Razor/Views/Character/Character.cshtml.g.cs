#pragma checksum "D:\Softuni\C# ASP.NET Core 2019\Course Project\WoWJunkyard\WoWJunkyard\Views\Character\Character.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2cd838014e06fcf2743975d6469f67292d43fda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Character_Character), @"mvc.1.0.view", @"/Views/Character/Character.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Character/Character.cshtml", typeof(AspNetCore.Views_Character_Character))]
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
#line 1 "D:\Softuni\C# ASP.NET Core 2019\Course Project\WoWJunkyard\WoWJunkyard\Views\_ViewImports.cshtml"
using WoWJunkyard;

#line default
#line hidden
#line 2 "D:\Softuni\C# ASP.NET Core 2019\Course Project\WoWJunkyard\WoWJunkyard\Views\_ViewImports.cshtml"
using WoWJunkyard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2cd838014e06fcf2743975d6469f67292d43fda", @"/Views/Character/Character.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26a98ca6314eaa7e90d072494c036630de8afb98", @"/Views/_ViewImports.cshtml")]
    public class Views_Character_Character : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WoWJunkyard.Data.Models.Character>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CharactersList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Character", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Softuni\C# ASP.NET Core 2019\Course Project\WoWJunkyard\WoWJunkyard\Views\Character\Character.cshtml"
  
    ViewData["Title"] = "Character";

#line default
#line hidden
            BeginContext(89, 144, true);
            WriteLiteral("\r\n<h1>Character</h1>\r\n\r\n<div>\r\n    <h4>CharacterInputModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(234, 48, false);
#line 14 "D:\Softuni\C# ASP.NET Core 2019\Course Project\WoWJunkyard\WoWJunkyard\Views\Character\Character.cshtml"
       Write(Html.DisplayNameFor(model => model.LastModified));

#line default
#line hidden
            EndContext();
            BeginContext(282, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(346, 44, false);
#line 17 "D:\Softuni\C# ASP.NET Core 2019\Course Project\WoWJunkyard\WoWJunkyard\Views\Character\Character.cshtml"
       Write(Html.DisplayFor(model => model.LastModified));

#line default
#line hidden
            EndContext();
            BeginContext(390, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(453, 40, false);
#line 20 "D:\Softuni\C# ASP.NET Core 2019\Course Project\WoWJunkyard\WoWJunkyard\Views\Character\Character.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(493, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(557, 36, false);
#line 23 "D:\Softuni\C# ASP.NET Core 2019\Course Project\WoWJunkyard\WoWJunkyard\Views\Character\Character.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(593, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(656, 41, false);
#line 26 "D:\Softuni\C# ASP.NET Core 2019\Course Project\WoWJunkyard\WoWJunkyard\Views\Character\Character.cshtml"
       Write(Html.DisplayNameFor(model => model.Realm));

#line default
#line hidden
            EndContext();
            BeginContext(697, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(761, 37, false);
#line 29 "D:\Softuni\C# ASP.NET Core 2019\Course Project\WoWJunkyard\WoWJunkyard\Views\Character\Character.cshtml"
       Write(Html.DisplayFor(model => model.Realm));

#line default
#line hidden
            EndContext();
            BeginContext(798, 64, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(863, 41, false);
#line 33 "D:\Softuni\C# ASP.NET Core 2019\Course Project\WoWJunkyard\WoWJunkyard\Views\Character\Character.cshtml"
       Write(Html.DisplayNameFor(model => model.Class));

#line default
#line hidden
            EndContext();
            BeginContext(904, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(968, 37, false);
#line 36 "D:\Softuni\C# ASP.NET Core 2019\Course Project\WoWJunkyard\WoWJunkyard\Views\Character\Character.cshtml"
       Write(Html.DisplayFor(model => model.Class));

#line default
#line hidden
            EndContext();
            BeginContext(1005, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1068, 40, false);
#line 39 "D:\Softuni\C# ASP.NET Core 2019\Course Project\WoWJunkyard\WoWJunkyard\Views\Character\Character.cshtml"
       Write(Html.DisplayNameFor(model => model.Race));

#line default
#line hidden
            EndContext();
            BeginContext(1108, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1172, 36, false);
#line 42 "D:\Softuni\C# ASP.NET Core 2019\Course Project\WoWJunkyard\WoWJunkyard\Views\Character\Character.cshtml"
       Write(Html.DisplayFor(model => model.Race));

#line default
#line hidden
            EndContext();
            BeginContext(1208, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1271, 41, false);
#line 45 "D:\Softuni\C# ASP.NET Core 2019\Course Project\WoWJunkyard\WoWJunkyard\Views\Character\Character.cshtml"
       Write(Html.DisplayNameFor(model => model.Level));

#line default
#line hidden
            EndContext();
            BeginContext(1312, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1376, 37, false);
#line 48 "D:\Softuni\C# ASP.NET Core 2019\Course Project\WoWJunkyard\WoWJunkyard\Views\Character\Character.cshtml"
       Write(Html.DisplayFor(model => model.Level));

#line default
#line hidden
            EndContext();
            BeginContext(1413, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1476, 53, false);
#line 51 "D:\Softuni\C# ASP.NET Core 2019\Course Project\WoWJunkyard\WoWJunkyard\Views\Character\Character.cshtml"
       Write(Html.DisplayNameFor(model => model.AchievementPoints));

#line default
#line hidden
            EndContext();
            BeginContext(1529, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1593, 49, false);
#line 54 "D:\Softuni\C# ASP.NET Core 2019\Course Project\WoWJunkyard\WoWJunkyard\Views\Character\Character.cshtml"
       Write(Html.DisplayFor(model => model.AchievementPoints));

#line default
#line hidden
            EndContext();
            BeginContext(1642, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1705, 43, false);
#line 57 "D:\Softuni\C# ASP.NET Core 2019\Course Project\WoWJunkyard\WoWJunkyard\Views\Character\Character.cshtml"
       Write(Html.DisplayNameFor(model => model.Faction));

#line default
#line hidden
            EndContext();
            BeginContext(1748, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1812, 39, false);
#line 60 "D:\Softuni\C# ASP.NET Core 2019\Course Project\WoWJunkyard\WoWJunkyard\Views\Character\Character.cshtml"
       Write(Html.DisplayFor(model => model.Faction));

#line default
#line hidden
            EndContext();
            BeginContext(1851, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1898, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2cd838014e06fcf2743975d6469f67292d43fda11521", async() => {
                BeginContext(1956, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1972, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WoWJunkyard.Data.Models.Character> Html { get; private set; }
    }
}
#pragma warning restore 1591
