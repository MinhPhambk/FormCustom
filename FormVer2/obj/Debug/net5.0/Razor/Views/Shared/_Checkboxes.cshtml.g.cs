#pragma checksum "D:\HTC-ITC\FormCustom\FormVer2\Views\Shared\_Checkboxes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0cabdc39ad9b64bf1cdfa79c6cbc7cb8aa55802"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Checkboxes), @"mvc.1.0.view", @"/Views/Shared/_Checkboxes.cshtml")]
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
#line 1 "D:\HTC-ITC\FormCustom\FormVer2\Views\_ViewImports.cshtml"
using FormVer2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HTC-ITC\FormCustom\FormVer2\Views\_ViewImports.cshtml"
using FormVer2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\HTC-ITC\FormCustom\FormVer2\Views\Shared\_Checkboxes.cshtml"
using FormVer2.Models.BL.PreviewBL;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0cabdc39ad9b64bf1cdfa79c6cbc7cb8aa55802", @"/Views/Shared/_Checkboxes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d123aca4cdd829931954c5d770bbcb49e5e505d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Checkboxes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PreviewComponentDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div style=\"border: 2px solid black;\" class=\"mt-1\">\r\n    <p>");
#nullable restore
#line 5 "D:\HTC-ITC\FormCustom\FormVer2\Views\Shared\_Checkboxes.cshtml"
  Write(Model.Alias);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <div class=\"list-group w-50\">\r\n");
#nullable restore
#line 7 "D:\HTC-ITC\FormCustom\FormVer2\Views\Shared\_Checkboxes.cshtml"
          
            for (int i = 0; i < Model.ListItem.Count(); i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label class=\"list-group-item\">\r\n                    <input type=\"checkbox\" class=\"form-check-input me-1\" name=\"hobbies\"> ");
#nullable restore
#line 11 "D:\HTC-ITC\FormCustom\FormVer2\Views\Shared\_Checkboxes.cshtml"
                                                                                    Write(Model.ListItem[i].Alias);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n");
#nullable restore
#line 13 "D:\HTC-ITC\FormCustom\FormVer2\Views\Shared\_Checkboxes.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PreviewComponentDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
