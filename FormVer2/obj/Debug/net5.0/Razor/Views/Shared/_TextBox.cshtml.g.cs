#pragma checksum "D:\HTC-ITC\FormCustom\FormVer2\Views\Shared\_TextBox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b322bef0777e16f5e52d6781ac816b559817e593"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TextBox), @"mvc.1.0.view", @"/Views/Shared/_TextBox.cshtml")]
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
#line 1 "D:\HTC-ITC\FormCustom\FormVer2\Views\Shared\_TextBox.cshtml"
using FormVer2.Models.BL.PreviewBL;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b322bef0777e16f5e52d6781ac816b559817e593", @"/Views/Shared/_TextBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d123aca4cdd829931954c5d770bbcb49e5e505d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TextBox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PreviewComponentDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\HTC-ITC\FormCustom\FormVer2\Views\Shared\_TextBox.cshtml"
  
    string str = Model.Alias;
    if (@Model.IsRequired)
    {
        str = str + "*";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"form-group\">\r\n    <label class=\"control-label\">");
#nullable restore
#line 12 "D:\HTC-ITC\FormCustom\FormVer2\Views\Shared\_TextBox.cshtml"
                            Write(str);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n    <input class=\"form-control\" />\r\n</div>");
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
