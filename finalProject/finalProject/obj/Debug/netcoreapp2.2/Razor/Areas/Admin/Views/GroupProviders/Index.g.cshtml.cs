#pragma checksum "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13917987f7d359eefb72b2f9d4e30d8135c8ce53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_GroupProviders_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/GroupProviders/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/GroupProviders/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_GroupProviders_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13917987f7d359eefb72b2f9d4e30d8135c8ce53", @"/Areas/Admin/Views/GroupProviders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_GroupProviders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<finalProject.Models.GroupProvider>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(156, 13, true);
            WriteLiteral("\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(169, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13917987f7d359eefb72b2f9d4e30d8135c8ce534641", async() => {
                BeginContext(192, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(206, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(299, 43, false);
#line 16 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TagName));

#line default
#line hidden
            EndContext();
            BeginContext(342, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(398, 45, false);
#line 19 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BackColor));

#line default
#line hidden
            EndContext();
            BeginContext(443, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(499, 48, false);
#line 22 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProviderName));

#line default
#line hidden
            EndContext();
            BeginContext(547, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(603, 45, false);
#line 25 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ImagePath));

#line default
#line hidden
            EndContext();
            BeginContext(648, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(704, 46, false);
#line 28 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HasOptions));

#line default
#line hidden
            EndContext();
            BeginContext(750, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(806, 55, false);
#line 31 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HasSecondaryOptions));

#line default
#line hidden
            EndContext();
            BeginContext(861, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(917, 44, false);
#line 34 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HasInput));

#line default
#line hidden
            EndContext();
            BeginContext(961, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1017, 53, false);
#line 37 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HasSecondaryInput));

#line default
#line hidden
            EndContext();
            BeginContext(1070, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1126, 54, false);
#line 40 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HasAdditionalInput));

#line default
#line hidden
            EndContext();
            BeginContext(1180, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1236, 48, false);
#line 43 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CoreProvider));

#line default
#line hidden
            EndContext();
            BeginContext(1284, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1340, 54, false);
#line 46 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProviderCategroyId));

#line default
#line hidden
            EndContext();
            BeginContext(1394, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 52 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1512, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1561, 42, false);
#line 55 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TagName));

#line default
#line hidden
            EndContext();
            BeginContext(1603, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1659, 44, false);
#line 58 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BackColor));

#line default
#line hidden
            EndContext();
            BeginContext(1703, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1759, 47, false);
#line 61 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProviderName));

#line default
#line hidden
            EndContext();
            BeginContext(1806, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1862, 44, false);
#line 64 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ImagePath));

#line default
#line hidden
            EndContext();
            BeginContext(1906, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1962, 45, false);
#line 67 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HasOptions));

#line default
#line hidden
            EndContext();
            BeginContext(2007, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2063, 54, false);
#line 70 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HasSecondaryOptions));

#line default
#line hidden
            EndContext();
            BeginContext(2117, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2173, 43, false);
#line 73 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HasInput));

#line default
#line hidden
            EndContext();
            BeginContext(2216, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2272, 52, false);
#line 76 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HasSecondaryInput));

#line default
#line hidden
            EndContext();
            BeginContext(2324, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2380, 53, false);
#line 79 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HasAdditionalInput));

#line default
#line hidden
            EndContext();
            BeginContext(2433, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2489, 57, false);
#line 82 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CoreProvider.BackColor));

#line default
#line hidden
            EndContext();
            BeginContext(2546, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2602, 53, false);
#line 85 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProviderCategroyId));

#line default
#line hidden
            EndContext();
            BeginContext(2655, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2710, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13917987f7d359eefb72b2f9d4e30d8135c8ce5316250", async() => {
                BeginContext(2755, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 88 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Index.cshtml"
                                       WriteLiteral(item.Id);

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
            BeginContext(2763, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2783, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13917987f7d359eefb72b2f9d4e30d8135c8ce5318615", async() => {
                BeginContext(2831, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 89 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Index.cshtml"
                                          WriteLiteral(item.Id);

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
            BeginContext(2842, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2862, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13917987f7d359eefb72b2f9d4e30d8135c8ce5320986", async() => {
                BeginContext(2909, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 90 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Index.cshtml"
                                         WriteLiteral(item.Id);

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
            BeginContext(2919, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 93 "C:\Users\acer\source\repos\finalProject\finalProject\Areas\Admin\Views\GroupProviders\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2958, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<finalProject.Models.GroupProvider>> Html { get; private set; }
    }
}
#pragma warning restore 1591
