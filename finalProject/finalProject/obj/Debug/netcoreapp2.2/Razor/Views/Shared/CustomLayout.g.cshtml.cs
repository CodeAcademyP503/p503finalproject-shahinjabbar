#pragma checksum "C:\Users\acer\source\repos\finalProject\finalProject\Views\Shared\CustomLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29743d563bbc7572db0a5b003a2c818c66b3d34e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_CustomLayout), @"mvc.1.0.view", @"/Views/Shared/CustomLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/CustomLayout.cshtml", typeof(AspNetCore.Views_Shared_CustomLayout))]
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
#line 1 "C:\Users\acer\source\repos\finalProject\finalProject\Views\_ViewImports.cshtml"
using finalProject;

#line default
#line hidden
#line 3 "C:\Users\acer\source\repos\finalProject\finalProject\Views\_ViewImports.cshtml"
using finalProject.Models.ViewModels;

#line default
#line hidden
#line 1 "C:\Users\acer\source\repos\finalProject\finalProject\Views\Shared\CustomLayout.cshtml"
using System.Runtime.InteropServices.ComTypes;

#line default
#line hidden
#line 2 "C:\Users\acer\source\repos\finalProject\finalProject\Views\Shared\CustomLayout.cshtml"
using finalProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29743d563bbc7572db0a5b003a2c818c66b3d34e", @"/Views/Shared/CustomLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05cbd9252d96ec989d7498d09845972fa604379e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_CustomLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-nice-select-1.1.0/css/nice-select.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/css/style.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-nice-select-1.1.0/js/jquery.nice-select.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(104, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(139, 503, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29743d563bbc7572db0a5b003a2c818c66b3d34e5480", async() => {
                BeginContext(145, 299, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"" />
    <link rel=""stylesheet"" href="" https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.2.1/css/bootstrap.min.css"" />
    ");
                EndContext();
                BeginContext(444, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "29743d563bbc7572db0a5b003a2c818c66b3d34e6173", async() => {
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
                EndContext();
                BeginContext(524, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(530, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "29743d563bbc7572db0a5b003a2c818c66b3d34e7506", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 12 "C:\Users\acer\source\repos\finalProject\finalProject\Views\Shared\CustomLayout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(604, 31, true);
                WriteLiteral("\r\n    <title>Document</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(642, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(644, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29743d563bbc7572db0a5b003a2c818c66b3d34e10481", async() => {
                BeginContext(650, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(659, 12, false);
#line 17 "C:\Users\acer\source\repos\finalProject\finalProject\Views\Shared\CustomLayout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(671, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
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
            EndContext();
            BeginContext(682, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(722, 103, true);
            WriteLiteral("\r\n</html>\r\n\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js\"></script>\r\n");
            EndContext();
            BeginContext(825, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29743d563bbc7572db0a5b003a2c818c66b3d34e12232", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(903, 21450, true);
            WriteLiteral(@"
<script>
    $(document).ready(function () {
        $('select').niceSelect();
    });
    let selected = null;
    window.selectedoption = selected;
    $("".submit"").on('click', function () {
        let categ = document.getElementsByClassName(""category"")[0].value;
        let lang = document.getElementsByClassName(""lang"")[0].value;
        let prov = document.getElementsByClassName(""providername"")[0].value;
        if (categ == ""mobile"") {
            let v = $(""#number"").val();
            if (v != """") {
                if (selected != null) {
                    $.ajax(
                        {
                            method: ""GET"",
                            url: 'https://localhost:44354/api/mobile/GetData',
                            data: { langid: lang, prefix: selected, number: v, provname: prov }
                        })
                        .done(function (msg) {
                            $("".error"").html("""");
                            $("".error2"").html("""");
            WriteLiteral(@"
                            $("".error3"").html("""");
                            ShowDataandPay();
                        })
                        .fail(function (msg) {
                            $("".error"").html("""");
                            if (lang == 1) {
                                $("".error3"").html(""Hech ne tapilmadi!!!"");
                            }
                            else if (lang == 2) {
                                $("".error3"").html(""Hичего не найдено!!!"");
                            }
                            else if (lang == 3) {
                                $("".error3"").html(""Nothing found!!!"");
                            }
                        });
                }
                else if (lang == 1) {
                    $("".error"").html(""Prefix sechin"");
                }
                else if (lang == 2) {
                    $("".error"").html(""выберите префикс"");
                }
                else if (lang == 3) {
              ");
            WriteLiteral(@"      $("".error"").html(""select prefix "");
                }
            }
            else if (lang == 1) {
                $("".error"").html(""Yanlish paramter"");
            }
            else if (lang == 2) {
                $("".error"").html(""неправильный параметр "");
            }
            else if (lang == 3) {
                $("".error"").html(""Wrong parameter"");
            }
        }
        if (categ == ""utility"") {
            let v = $(""#number"").val();
            if (v != """") {
                if (selected != null) {
                    $.ajax(
                        {
                            method: ""GET"",
                            url: 'https://localhost:44354/api/utility/GetData',
                            data: { langid: lang, prefix: selected, number: v, provname: prov }
                        })
                        .done(function (msg) {
                            $("".error"").html("""");
                            $("".error2"").html("""");
              ");
            WriteLiteral(@"              $("".error3"").html("""");
                            ShowDataandPay();
                        })
                        .fail(function (msg) {
                            $("".error"").html("""");
                            if (lang == 1) {
                                $("".error3"").html(""Hech ne tapilmadi!!!"");
                            }
                            else if (lang == 2) {
                                $("".error3"").html(""Hичего не найдено!!!"");
                            }
                            else if (lang == 3) {
                                $("".error3"").html(""Nothing found!!!"");
                            }
                        });
                }
                else if (lang == 1) {
                    $("".error"").html(""Prefix sechin"");
                }
                else if (lang == 2) {
                    $("".error"").html(""выберите префикс"");
                }
                else if (lang == 3) {
                    $("".error");
            WriteLiteral(@""").html(""select prefix "");
                }
            }
            else if (lang == 1) {
                $("".error"").html(""Yanlish paramter"");
            }
            else if (lang == 2) {
                $("".error"").html(""неправильный параметр "");
            }
            else if (lang == 3) {
                $("".error"").html(""Wrong parameter"");
            }
        }
        if (categ == ""bank"") {
            let v = $(""#number"").val();
            let c = $(""#numb"").val();
            if (v != """") {
                if (c != """") {
                    $.ajax(
                        {
                            method: ""GET"",
                            url: 'https://localhost:44354/api/bank/GetData',
                            data: { number: v, secondnumber: c, provname: prov }
                        })
                        .done(function (msg) {
                            $("".error"").html("""");
                            $("".error2"").html("""");
                    ");
            WriteLiteral(@"        $("".error3"").html("""");
                            ShowDataandPay();
                        })
                        .fail(function (msg) {
                            $("".error"").html("""");
                            if (lang == 1) {
                                $("".error3"").html(""Hech ne tapilmadi!!!"");
                            }
                            else if (lang == 2) {
                                $("".error3"").html(""Hичего не найдено!!!"");
                            }
                            else if (lang == 3) {
                                $("".error3"").html(""Nothing found!!!"");
                            }
                        });
                }
                else if (lang == 1) {
                    $("".error"").html(""Yanlish paramter"");
                }
                else if (lang == 2) {
                    $("".error"").html(""неправильный параметр"");
                }
                else if (lang == 3) {
                    $("".err");
            WriteLiteral(@"or"").html(""Wrong parameter"");
                }
            }
            else if (lang == 1) {
                $("".error"").html(""Yanlish paramter"");
            }
            else if (lang == 2) {
                $("".error"").html(""неправильный параметр "");
            }
            else if (lang == 3) {
                $("".error"").html(""Wrong parameter"");
            }
        }
        if (categ == ""state"") {
            let v = $(""#number"").val();
            if (v != """") {
                if (selected != null) {
                    $.ajax(
                        {
                            method: ""GET"",
                            url: 'https://localhost:44354/api/state/GetData',
                            data: { langid: lang, prefix: selected, number: v, provname: prov }
                        })
                        .done(function (msg) {
                            $("".error"").html("""");
                            $("".error2"").html("""");
                            $(");
            WriteLiteral(@""".error3"").html("""");
                            ShowDataandPay();
                        })
                        .fail(function (msg) {
                            $("".error"").html("""");
                            if (lang == 1) {
                                $("".error3"").html(""Hech ne tapilmadi!!!"");
                            }
                            else if (lang == 2) {
                                $("".error3"").html(""Hичего не найдено!!!"");
                            }
                            else if (lang == 3) {
                                $("".error3"").html(""Nothing found!!!"");
                            }
                        });
                }
                else if (lang == 1) {
                    $("".error"").html(""Prefix sechin"");
                }
                else if (lang == 2) {
                    $("".error"").html(""выберите префикс"");
                }
                else if (lang == 3) {
                    $("".error"").html(""select ");
            WriteLiteral(@"prefix "");
                }
            }
            else if (lang == 1) {
                $("".error"").html(""Yanlish paramter"");
            }
            else if (lang == 2) {
                $("".error"").html(""неправильный параметр "");
            }
            else if (lang == 3) {
                $("".error"").html(""Wrong parameter"");
            }
        }
        if (categ == ""tv"") {
            let v = $(""#number"").val();
            if (v != """") {
                $.ajax(
                    {
                        method: ""GET"",
                        url: 'https://localhost:44354/api/tv/GetData',
                        data: { number: v, provname: prov }
                    })
                    .done(function (msg) {
                        $("".error"").html("""");
                        $("".error2"").html("""");
                        $("".error3"").html("""");
                        ShowDataandPay();
                    })
                    .fail(function (msg) {
     ");
            WriteLiteral(@"                   $("".error"").html("""");
                        if (lang == 1) {
                            $("".error3"").html(""Hech ne tapilmadi!!!"");
                        }
                        else if (lang == 2) {
                            $("".error3"").html(""Hичего не найдено!!!"");
                        }
                        else if (lang == 3) {
                            $("".error3"").html(""Nothing found!!!"");
                        }
                    });

            }
            else if (lang == 1) {
                $("".error"").html(""Prefix sechin"");
            }
            else if (lang == 2) {
                $("".error"").html(""выберите префикс"");
            }
            else if (lang == 3) {
                $("".error"").html(""select prefix "");
            }
        }
        if (categ == ""internet"") {
            let v = $(""#number"").val();
            if (v != """") {
                $.ajax(
                    {
                        method: ""GET""");
            WriteLiteral(@",
                        url: 'https://localhost:44354/api/internet/GetData',
                        data: { number: v, provname: prov }
                    })
                    .done(function (msg) {
                        $("".error"").html("""");
                        $("".error2"").html("""");
                        $("".error3"").html("""");
                        ShowDataandPay();
                    })
                    .fail(function (msg) {
                        $("".error"").html("""");
                        if (lang == 1) {
                            $("".error3"").html(""Hech ne tapilmadi!!!"");
                        }
                        else if (lang == 2) {
                            $("".error3"").html(""Hичего не найдено!!!"");
                        }
                        else if (lang == 3) {
                            $("".error3"").html(""Nothing found!!!"");
                        }
                    });

            }
            else if (lang == 1) {
       ");
            WriteLiteral(@"         $("".error"").html(""Prefix sechin"");
            }
            else if (lang == 2) {
                $("".error"").html(""выберите префикс"");
            }
            else if (lang == 3) {
                $("".error"").html(""select prefix "");
            }
        }
        if (categ == ""phone"") {
            let v = $(""#number"").val();
            if (v != """") {
                $.ajax(
                    {
                        method: ""GET"",
                        url: 'https://localhost:44354/api/phone/GetData',
                        data: { number: v, provname: prov }
                    })
                    .done(function (msg) {
                        $("".error"").html("""");
                        $("".error2"").html("""");
                        $("".error3"").html("""");
                        ShowDataandPay();
                    })
                    .fail(function (msg) {
                        $("".error"").html("""");
                        if (lang == 1) {
        ");
            WriteLiteral(@"                    $("".error3"").html(""Hech ne tapilmadi!!!"");
                        }
                        else if (lang == 2) {
                            $("".error3"").html(""Hичего не найдено!!!"");
                        }
                        else if (lang == 3) {
                            $("".error3"").html(""Nothing found!!!"");
                        }
                    });

            }
            else if (lang == 1) {
                $("".error"").html(""Prefix sechin"");
            }
            else if (lang == 2) {
                $("".error"").html(""выберите префикс"");
            }
            else if (lang == 3) {
                $("".error"").html(""select prefix "");
            }
        }
        if (categ == ""Entertainment"") {
            let v = $(""#number"").val();
            if (v != """") {
                if (selected != null) {
                    $.ajax(
                        {
                            method: ""GET"",
                            url");
            WriteLiteral(@": 'https://localhost:44354/api/utility/GetData',
                            data: { langid: lang, prefix: selected, number: v, provname: prov }
                        })
                        .done(function (msg) {
                            $("".error"").html("""");
                            $("".error2"").html("""");
                            $("".error3"").html("""");
                            ShowDataandPay();
                        })
                        .fail(function (msg) {
                            $("".error"").html("""");
                            if (lang == 1) {
                                $("".error3"").html(""Hech ne tapilmadi!!!"");
                            }
                            else if (lang == 2) {
                                $("".error3"").html(""Hичего не найдено!!!"");
                            }
                            else if (lang == 3) {
                                $("".error3"").html(""Nothing found!!!"");
                            }
       ");
            WriteLiteral(@"                 });
                }
                else if (lang == 1) {
                    $("".error"").html(""Prefix sechin"");
                }
                else if (lang == 2) {
                    $("".error"").html(""выберите префикс"");
                }
                else if (lang == 3) {
                    $("".error"").html(""select prefix "");
                }
            }
            else if (lang == 1) {
                $("".error"").html(""Yanlish paramter"");
            }
            else if (lang == 2) {
                $("".error"").html(""неправильный параметр "");
            }
            else if (lang == 3) {
                $("".error"").html(""Wrong parameter"");
            }
        }
        if (categ == ""e_wallet"") {
            let v = $(""#number"").val();
            if (v != """") {
                if (selected != null) {
                    $.ajax(
                        {
                            method: ""GET"",
                            url: 'https://loc");
            WriteLiteral(@"alhost:44354/api/ewallet/GetData',
                            data: { langid: lang, prefix: selected, number: v, provname: prov }
                        })
                        .done(function (msg) {
                            $("".error"").html("""");
                            $("".error2"").html("""");
                            $("".error3"").html("""");
                            ShowDataandPay();
                        })
                        .fail(function (msg) {
                            $("".error"").html("""");
                            if (lang == 1) {
                                $("".error3"").html(""Hech ne tapilmadi!!!"");
                            }
                            else if (lang == 2) {
                                $("".error3"").html(""Hичего не найдено!!!"");
                            }
                            else if (lang == 3) {
                                $("".error3"").html(""Nothing found!!!"");
                            }
                     ");
            WriteLiteral(@"   });
                }
                else if (lang == 1) {
                    $("".error"").html(""Prefix sechin"");
                }
                else if (lang == 2) {
                    $("".error"").html(""выберите префикс"");
                }
                else if (lang == 3) {
                    $("".error"").html(""select prefix "");
                }
            }
            else if (lang == 1) {
                $("".error"").html(""Yanlish paramter"");
            }
            else if (lang == 2) {
                $("".error"").html(""неправильный параметр "");
            }
            else if (lang == 3) {
                $("".error"").html(""Wrong parameter"");
            }
        }
    })
    if (hasoptions == true) {
        let prefixtxt = document.getElementsByClassName(""label"")[0].innerHTML;
    }
    let lbltext = document.getElementsByClassName(""lbl"")[0].innerHTML;
    function ShowDataandPay() {
        $("".first"").css(""display"", ""none"");
        if (hasoptions == tru");
            WriteLiteral(@"e) {
            document.getElementsByClassName(""label"")[0].innerHTML += ':' + selected;
        }
        document.getElementsByClassName(""lbl"")[0].innerHTML += ':' + $(""#number"").val();
        $(""#number"").val("""");
        let btn = document.createElement(""button"");
        btn.className = ""btn btn-primary secondsubmit"";
        let btn2 = document.createElement(""button"");
        btn2.className = ""btn btn-info secondhome"";
        let langname = document.getElementsByClassName(""lang"")[0].value;
        if (langname == ""1"") {
            $("".labels"").text(""Məbləğ"");
            btn.innerHTML = ""Davam Et"";
            btn2.innerHTML = ""Imtina Et"";
        }
        else if (langname == ""2"") {
            $("".labels"").text(""Сумма"");
            btn.innerHTML = ""Далее"";
            btn2.innerHTML = ""Отменить"";
        }
        else if (langname == ""3"") {
            $("".labels"").text(""Amount"");
            btn.innerHTML = ""Continue"";
            btn2.innerHTML = ""Cancel"";
        }
");
            WriteLiteral(@"
        document.getElementsByClassName(""sumbitSection"")[0].appendChild(btn);
        document.getElementsByClassName(""sumbitSection"")[0].appendChild(btn2);
        $("".submit"").css(""display"", ""none"");
        $("".home"").css(""display"", ""none"");
    }

    let seconsubmit = document.getElementsByClassName(""secondsubmit"")[0];
    $(document).on(""click"",
        "".secondsubmit"",
        function () {
            let v = $(""#number"").val();
            let parseddata = parseInt(v);
            let langname = document.getElementsByClassName(""lang"")[0].value;
            if (langname == ""1"") {
                if (!isNaN(parseddata) && (v != """")) {
                    $("".error4"").text(""Odenishiniz ugurlu oldu"");
                    $("".error4"").css(""color"", ""green"");
                } else {
                    $("".error4"").text(""Odenishiniz ugursuz oldu.Duzgun parameter daxil edin"");
                    $("".error4"").css(""color"", ""red"");
                }
            }
            else if (l");
            WriteLiteral(@"angname == ""2"") {
                if (!isNaN(parseddata) && (v != """")) {
                    $("".error4"").text(""Oплата успешно завершен"");
                    $("".error4"").css(""color"", ""green"");
                } else {
                    $("".error4"").text(""Oплата нe завершен.Bведите правильный параметр"");
                    $("".error4"").css(""color"", ""red"");
                }
            }
            else if (langname == ""3"") {
                if (!isNaN(parseddata) && (v != """")) {
                    $("".error4"").text(""Payment completed successfully"");
                    $("".error4"").css(""color"", ""green"");
                } else {
                    $("".error4"").text(""Payment completed unsuccessfully.Enter the correct parameter"");
                    $("".error4"").css(""color"", ""red"");
                }
            }
        });

    $(document).on(""click"",
        "".secondhome"",
        function () {
            $("".first"").css(""display"", ""block"");
            if (hasoptions == tr");
            WriteLiteral(@"ue) {
                document.getElementsByClassName(""label"")[0].innerHTML = prefixtxt;
            }
            document.getElementsByClassName(""lbl"")[0].innerHTML = lbltext;
            $("".secondsubmit"").css(""display"", ""none"");
            $("".secondhome"").css(""display"", ""none"");
            $("".submit"").css(""display"", ""block"");
            $("".home"").css(""display"", ""block"");
            $("".labels"").text("""");
            $("".error4"").text("""");
            $(""#number"").val("""");
        });
    //function HideData() {

    //$(document).ready(function () {
    //    $("".secondsubmit"").click(function () {

    //    });
    //});
    ////seconsubmit.addEventListener(""click"", function () {

    //})
    //$("".secondsubmit"").click(function () {

    //})

    $("".first"").on('change',
        'select',
        function () {
            selected = $(this).val();
            console.log(selected);
        });
</script>



");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591