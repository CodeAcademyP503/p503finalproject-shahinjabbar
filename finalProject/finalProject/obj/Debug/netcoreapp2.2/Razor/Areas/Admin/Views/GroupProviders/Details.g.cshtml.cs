#pragma checksum "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aceb69bff9c9cf3eccd62318a1c6324b32229373"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_GroupProviders_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/GroupProviders/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/GroupProviders/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_GroupProviders_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aceb69bff9c9cf3eccd62318a1c6324b32229373", @"/Areas/Admin/Views/GroupProviders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_GroupProviders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<finalProject.Models.GroupProvider>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(145, 136, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>GroupProvider</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(282, 43, false);
#line 15 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TagName));

#line default
#line hidden
            EndContext();
            BeginContext(325, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(389, 39, false);
#line 18 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Details.cshtml"
       Write(Html.DisplayFor(model => model.TagName));

#line default
#line hidden
            EndContext();
            BeginContext(428, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(491, 45, false);
#line 21 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BackColor));

#line default
#line hidden
            EndContext();
            BeginContext(536, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(600, 41, false);
#line 24 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Details.cshtml"
       Write(Html.DisplayFor(model => model.BackColor));

#line default
#line hidden
            EndContext();
            BeginContext(641, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(704, 48, false);
#line 27 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProviderName));

#line default
#line hidden
            EndContext();
            BeginContext(752, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(816, 44, false);
#line 30 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProviderName));

#line default
#line hidden
            EndContext();
            BeginContext(860, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(923, 45, false);
#line 33 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ImagePath));

#line default
#line hidden
            EndContext();
            BeginContext(968, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1032, 41, false);
#line 36 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Details.cshtml"
       Write(Html.DisplayFor(model => model.ImagePath));

#line default
#line hidden
            EndContext();
            BeginContext(1073, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1136, 46, false);
#line 39 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HasOptions));

#line default
#line hidden
            EndContext();
            BeginContext(1182, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1246, 42, false);
#line 42 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Details.cshtml"
       Write(Html.DisplayFor(model => model.HasOptions));

#line default
#line hidden
            EndContext();
            BeginContext(1288, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1351, 55, false);
#line 45 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HasSecondaryOptions));

#line default
#line hidden
            EndContext();
            BeginContext(1406, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1470, 51, false);
#line 48 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Details.cshtml"
       Write(Html.DisplayFor(model => model.HasSecondaryOptions));

#line default
#line hidden
            EndContext();
            BeginContext(1521, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1584, 44, false);
#line 51 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HasInput));

#line default
#line hidden
            EndContext();
            BeginContext(1628, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1692, 40, false);
#line 54 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Details.cshtml"
       Write(Html.DisplayFor(model => model.HasInput));

#line default
#line hidden
            EndContext();
            BeginContext(1732, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1795, 53, false);
#line 57 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HasSecondaryInput));

#line default
#line hidden
            EndContext();
            BeginContext(1848, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1912, 49, false);
#line 60 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Details.cshtml"
       Write(Html.DisplayFor(model => model.HasSecondaryInput));

#line default
#line hidden
            EndContext();
            BeginContext(1961, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2024, 54, false);
#line 63 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HasAdditionalInput));

#line default
#line hidden
            EndContext();
            BeginContext(2078, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2142, 50, false);
#line 66 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Details.cshtml"
       Write(Html.DisplayFor(model => model.HasAdditionalInput));

#line default
#line hidden
            EndContext();
            BeginContext(2192, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2255, 48, false);
#line 69 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CoreProvider));

#line default
#line hidden
            EndContext();
            BeginContext(2303, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2367, 54, false);
#line 72 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Details.cshtml"
       Write(Html.DisplayFor(model => model.CoreProvider.BackColor));

#line default
#line hidden
            EndContext();
            BeginContext(2421, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2484, 54, false);
#line 75 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProviderCategroyId));

#line default
#line hidden
            EndContext();
            BeginContext(2538, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2602, 50, false);
#line 78 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProviderCategroyId));

#line default
#line hidden
            EndContext();
            BeginContext(2652, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2699, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aceb69bff9c9cf3eccd62318a1c6324b3222937314067", async() => {
                BeginContext(2745, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 83 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2753, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2761, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aceb69bff9c9cf3eccd62318a1c6324b3222937316410", async() => {
                BeginContext(2783, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2799, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<finalProject.Models.GroupProvider> Html { get; private set; }
    }
}
#pragma warning restore 1591
