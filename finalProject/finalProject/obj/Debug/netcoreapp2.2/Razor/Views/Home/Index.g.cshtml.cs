#pragma checksum "C:\Users\acer\source\repos\finalProject\finalProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cff896a435fd0a1dfc8b9ed48b9515fc35d1f20"
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
#line 1 "C:\Users\acer\source\repos\finalProject\finalProject\Views\_ViewImports.cshtml"
using finalProject;

#line default
#line hidden
#line 2 "C:\Users\acer\source\repos\finalProject\finalProject\Views\_ViewImports.cshtml"
using finalProject.Models;

#line default
#line hidden
#line 3 "C:\Users\acer\source\repos\finalProject\finalProject\Views\_ViewImports.cshtml"
using finalProject.Models.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\acer\source\repos\finalProject\finalProject\Views\_ViewImports.cshtml"
using System.Runtime.InteropServices.ComTypes;

#line default
#line hidden
#line 1 "C:\Users\acer\source\repos\finalProject\finalProject\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Account.Internal;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cff896a435fd0a1dfc8b9ed48b9515fc35d1f20", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05cbd9252d96ec989d7498d09845972fa604379e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<finalProject.Views.ViewModels.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(119, 185, true);
            WriteLiteral("\r\n<script src=\"https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js\"></script>\r\n<script>\r\n    let mainWidth = 1200;\r\n    let secondWidth = 700;\r\n    let arry = JSON.parse(\'");
            EndContext();
            BeginContext(305, 44, false);
#line 8 "C:\Users\acer\source\repos\finalProject\finalProject\Views\Home\Index.cshtml"
                      Write(Json.Serialize(@Model.TopProviderViewModels));

#line default
#line hidden
            EndContext();
            BeginContext(349, 37, true);
            WriteLiteral("\');\r\n    let secondArray=JSON.parse(\'");
            EndContext();
            BeginContext(387, 45, false);
#line 9 "C:\Users\acer\source\repos\finalProject\finalProject\Views\Home\Index.cshtml"
                           Write(Json.Serialize(@Model.CoreProviderViewModels));

#line default
#line hidden
            EndContext();
            BeginContext(432, 65, true);
            WriteLiteral("\')\r\n    let $width = secondWidth / 3;\r\n    let langConfigArray = ");
            EndContext();
            BeginContext(498, 39, false);
#line 11 "C:\Users\acer\source\repos\finalProject\finalProject\Views\Home\Index.cshtml"
                     Write(Html.Raw(Json.Serialize(@Model.LangId)));

#line default
#line hidden
            EndContext();
            BeginContext(537, 27, true);
            WriteLiteral(";\r\n    let logoArrFromDb = ");
            EndContext();
            BeginContext(565, 43, false);
#line 12 "C:\Users\acer\source\repos\finalProject\finalProject\Views\Home\Index.cshtml"
                   Write(Html.Raw(Json.Serialize(@Model.IndexPhoto)));

#line default
#line hidden
            EndContext();
            BeginContext(608, 135, true);
            WriteLiteral(";\r\n    let secondLogoPath = document.createElement(\"img\");\r\n    let mainLogoPath = document.createElement(\"img\");\r\n    let footerText =");
            EndContext();
            BeginContext(744, 44, false);
#line 15 "C:\Users\acer\source\repos\finalProject\finalProject\Views\Home\Index.cshtml"
               Write(Html.Raw(@Json.Serialize(@Model.FooterText)));

#line default
#line hidden
            EndContext();
            BeginContext(788, 18, true);
            WriteLiteral(";\r\n    let langid=");
            EndContext();
            BeginContext(807, 44, false);
#line 16 "C:\Users\acer\source\repos\finalProject\finalProject\Views\Home\Index.cshtml"
          Write(Html.Raw(@Json.Serialize(@Model.LanguageId)));

#line default
#line hidden
            EndContext();
            BeginContext(851, 545, true);
            WriteLiteral(@";
    let logoArr = [mainLogoPath, secondLogoPath];
    let classNameArray = [""mainlogo"", ""secondlogo""];
    function init() {
        let mainparent = document.createElement(""div"");
        let langConfig = document.createElement(""div"");
        langConfig.className = ""langConfig"";
        mainparent.className = ""firstParent"";
        let loopCount;
        loopCount = 0;
        for (let k of logoArrFromDb) {
            let log = createElement(""img"", '', mainparent, classNameArray[loopCount], ""#fff"");
            log.src = '");
            EndContext();
            BeginContext(1397, 21, false);
#line 28 "C:\Users\acer\source\repos\finalProject\finalProject\Views\Home\Index.cshtml"
                  Write(Url.Content("~/img/"));

#line default
#line hidden
            EndContext();
            BeginContext(1418, 866, true);
            WriteLiteral(@"' + k;
            loopCount++;
        }
        let container = document.createElement(""div"");
        container.className = ""container"";
        document.body.appendChild(container);
        container.appendChild(mainparent);
        container.appendChild(langConfig);
        let parent = createElement(""div"", mainWidth, document.body, ""parent"", null);
        let width = mainWidth / arry.length;
        for (let element of arry) {
            var imgContainer = document.createElement(""div"");
            imgContainer.className=""imgContainer"";
            let child = createElement(
                element.tagName,
                null,
                parent,
                ""child"",
                element.backColor,
                null
            );
            child.setAttribute(""data-id"", element.id);
            child.href='");
            EndContext();
            BeginContext(2285, 32, false);
#line 50 "C:\Users\acer\source\repos\finalProject\finalProject\Views\Home\Index.cshtml"
                   Write(Url.Action("Index", "CheckData"));

#line default
#line hidden
            EndContext();
            BeginContext(2317, 182, true);
            WriteLiteral("?id=\' + child.getAttribute(\"data-id\") + \'&langId=\' + langid;\r\n            parent.appendChild(child);\r\n            let $logo = document.createElement(\"img\");\r\n            $logo.src =\'");
            EndContext();
            BeginContext(2500, 21, false);
#line 53 "C:\Users\acer\source\repos\finalProject\finalProject\Views\Home\Index.cshtml"
                   Write(Url.Content("~/img/"));

#line default
#line hidden
            EndContext();
            BeginContext(2521, 322, true);
            WriteLiteral(@"' + element.logo;
            $logo.className = ""logo"";
            imgContainer.appendChild($logo);
            child.appendChild(imgContainer);
        }
        for (let k of langConfigArray ) {
            let lang = createElement(""img"", 50 + ""px"", langConfig, ""lang_Icon"", '#fff', '');
            lang.src = '");
            EndContext();
            BeginContext(2844, 21, false);
#line 60 "C:\Users\acer\source\repos\finalProject\finalProject\Views\Home\Index.cshtml"
                   Write(Url.Content("~/img/"));

#line default
#line hidden
            EndContext();
            BeginContext(2865, 611, true);
            WriteLiteral(@"' + k.imagePath;
            lang.setAttribute(""data-langid"", k.id)
        }
        let secondParent = document.createElement(""div"");
        secondParent.className = ""secondparent"";
        document.body.appendChild(secondParent);
        for (let sec_element of secondArray) {
            let secondChild = createElement(sec_element.tagName,
                $width,
                secondParent,
                ""secondchild"",
                sec_element.backColor,
                ""secondchild"")
            secondChild.setAttribute(""data-id"", sec_element.id)
            secondChild.href = '");
            EndContext();
            BeginContext(3477, 31, false);
#line 74 "C:\Users\acer\source\repos\finalProject\finalProject\Views\Home\Index.cshtml"
                           Write(Url.Action("Index", "Provider"));

#line default
#line hidden
            EndContext();
            BeginContext(3508, 169, true);
            WriteLiteral("?id=\' + sec_element.id;\r\n\r\n            let $logos = document.createElement(\"img\");\r\n            let logoblock = document.createElement(\"div\");\r\n            $logos.src =\'");
            EndContext();
            BeginContext(3678, 21, false);
#line 78 "C:\Users\acer\source\repos\finalProject\finalProject\Views\Home\Index.cshtml"
                    Write(Url.Content("~/img/"));

#line default
#line hidden
            EndContext();
            BeginContext(3699, 1707, true);
            WriteLiteral(@"'+ sec_element.logo;
            $logos.className = ""secondlogo"";
            logoblock.className = ""logoblock"";
            logoblock.appendChild($logos);
            secondChild.appendChild(logoblock);

            secondParent.appendChild(secondChild);
            let txt = document.createElement(""div"");
            txt.className = ""textblock"";
            txt.innerHTML = sec_element.text;
            secondChild.appendChild(txt);

        }
        let footer = document.createElement(""div"");
        footer.className = ""footer"";
        footer.innerHTML = footerText;
        document.body.appendChild(footer);

        $('.lang_Icon').on(""click"", function() {
            $.ajax(
                    {
                        method:""GET"",
                        url: ""/Home/LangActionResult"",
                        data: { id: this.getAttribute(""data-langid"")}
                    })
                .done(function( msg ) {
                    let txt = document.getElementsByClassNam");
            WriteLiteral(@"e(""textblock"");
                    let arr = [...msg.coreProviderViewModels];
                    let secArr = [...msg.topProviderViewModels];
                    console.log(secArr);
                    let dataAttributes = document.getElementsByClassName(""secondchild"");
                    let childAttributes = document.getElementsByClassName(""child"");
                    let footerTxt = msg.footerText;
                    let count = 0;
                    for (let x of arr) {
                        txt[count].innerHTML = x.text;
                        dataAttributes[count].setAttribute(""data-id"", x.id);
                        dataAttributes[count].href = '");
            EndContext();
            BeginContext(5407, 31, false);
#line 115 "C:\Users\acer\source\repos\finalProject\finalProject\Views\Home\Index.cshtml"
                                                 Write(Url.Action("Index", "Provider"));

#line default
#line hidden
            EndContext();
            BeginContext(5438, 355, true);
            WriteLiteral(@"?id=' + x.id;
                        count++;
                    }
                    langid = msg.languageId;
                    console.log(langid);
                    for (var i = 0; i < secArr.length; i++) {
                        childAttributes[i].setAttribute(""data-id"", secArr[i].id);
                        childAttributes[i].href='");
            EndContext();
            BeginContext(5794, 32, false);
#line 122 "C:\Users\acer\source\repos\finalProject\finalProject\Views\Home\Index.cshtml"
                                            Write(Url.Action("Index", "CheckData"));

#line default
#line hidden
            EndContext();
            BeginContext(5826, 595, true);
            WriteLiteral(@"?id=' + childAttributes[i].getAttribute(""data-id"") + '&langId=' + langid;
                    }
                    $("".footer"").html(footerTxt);
                });
        })

    }

    function createElement(_tagName, _width, _parent, _className, background, _id) {
        let element = document.createElement(_tagName);
        element.style.width = _width + ""px"";
        element.className = _className;
        element.id = _id;
        element.style.background = background;
        _parent.appendChild(element);
        return element;
    }
    init();

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<finalProject.Views.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
