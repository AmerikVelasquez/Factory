#pragma checksum "C:\Users\Amerik\Desktop\Factory.Solution\Factory\Views\Machines\AddEngineer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c57b8d2a80e5009f9939d8219eed642f26c5e4c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Machines_AddEngineer), @"mvc.1.0.view", @"/Views/Machines/AddEngineer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c57b8d2a80e5009f9939d8219eed642f26c5e4c3", @"/Views/Machines/AddEngineer.cshtml")]
    public class Views_Machines_AddEngineer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Factory.Models.Machine>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Add an Engineer</h2>\r\n\r\n<h4>Add an Engineer to this machine: ");
#nullable restore
#line 5 "C:\Users\Amerik\Desktop\Factory.Solution\Factory\Views\Machines\AddEngineer.cshtml"
                                Write(Html.DisplayFor(model =>model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Amerik\Desktop\Factory.Solution\Factory\Views\Machines\AddEngineer.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Amerik\Desktop\Factory.Solution\Factory\Views\Machines\AddEngineer.cshtml"
Write(Html.HiddenFor(model => model.MachineId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Amerik\Desktop\Factory.Solution\Factory\Views\Machines\AddEngineer.cshtml"
Write(Html.Label("Select Engineer"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Amerik\Desktop\Factory.Solution\Factory\Views\Machines\AddEngineer.cshtml"
Write(Html.DropDownList("EngineerId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Save\" />\r\n");
#nullable restore
#line 15 "C:\Users\Amerik\Desktop\Factory.Solution\Factory\Views\Machines\AddEngineer.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>");
#nullable restore
#line 17 "C:\Users\Amerik\Desktop\Factory.Solution\Factory\Views\Machines\AddEngineer.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Factory.Models.Machine> Html { get; private set; }
    }
}
#pragma warning restore 1591
