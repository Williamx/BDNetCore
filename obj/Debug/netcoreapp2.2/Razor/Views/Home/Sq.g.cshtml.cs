#pragma checksum "C:\blog13\Views\Home\Sq.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcdb98efeac34107a57dd4e687beda4ee70f856e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Sq), @"mvc.1.0.view", @"/Views/Home/Sq.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Sq.cshtml", typeof(AspNetCore.Views_Home_Sq))]
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
#line 1 "C:\blog13\Views\_ViewImports.cshtml"
using blog13;

#line default
#line hidden
#line 2 "C:\blog13\Views\_ViewImports.cshtml"
using blog13.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcdb98efeac34107a57dd4e687beda4ee70f856e", @"/Views/Home/Sq.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6dec0fc0cf516fc61d6e5617b1ed26c9427b48e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Sq : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<blog13.Models.Agenda>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(44, 65, true);
            WriteLiteral("\r\n\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(110, 38, false);
#line 9 "C:\blog13\Views\Home\Sq.cshtml"
       Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(148, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(192, 40, false);
#line 12 "C:\blog13\Views\Home\Sq.cshtml"
       Write(Html.DisplayNameFor(model => model.nome));

#line default
#line hidden
            EndContext();
            BeginContext(232, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(276, 44, false);
#line 15 "C:\blog13\Views\Home\Sq.cshtml"
       Write(Html.DisplayNameFor(model => model.telefone));

#line default
#line hidden
            EndContext();
            BeginContext(320, 49, true);
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 20 "C:\blog13\Views\Home\Sq.cshtml"
 foreach (var item in @ViewBag.g) {

#line default
#line hidden
            BeginContext(406, 36, true);
            WriteLiteral("    <tr>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(443, 17, false);
#line 23 "C:\blog13\Views\Home\Sq.cshtml"
       Write(Html.Raw(item.id));

#line default
#line hidden
            EndContext();
            BeginContext(460, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(504, 19, false);
#line 26 "C:\blog13\Views\Home\Sq.cshtml"
       Write(Html.Raw(item.nome));

#line default
#line hidden
            EndContext();
            BeginContext(523, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(567, 23, false);
#line 29 "C:\blog13\Views\Home\Sq.cshtml"
       Write(Html.Raw(item.telefone));

#line default
#line hidden
            EndContext();
            BeginContext(590, 31, true);
            WriteLiteral("\r\n        </td>\r\n \r\n    </tr>\r\n");
            EndContext();
#line 33 "C:\blog13\Views\Home\Sq.cshtml"
}

#line default
#line hidden
            BeginContext(624, 12, true);
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<blog13.Models.Agenda>> Html { get; private set; }
    }
}
#pragma warning restore 1591
