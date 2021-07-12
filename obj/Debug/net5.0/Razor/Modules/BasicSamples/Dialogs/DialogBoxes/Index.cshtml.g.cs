#pragma checksum "C:\Users\sadeghi\source\repos\MovieTutorial\MovieTutorial\MovieTutorial.Web\Modules\BasicSamples\Dialogs\DialogBoxes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fc7a84bf1ed1154f23006fdc3b4c9da00b7768d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_BasicSamples_Dialogs_DialogBoxes_Index), @"mvc.1.0.view", @"/Modules/BasicSamples/Dialogs/DialogBoxes/Index.cshtml")]
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
#line 1 "C:\Users\sadeghi\source\repos\MovieTutorial\MovieTutorial\MovieTutorial.Web\Modules\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sadeghi\source\repos\MovieTutorial\MovieTutorial\MovieTutorial.Web\Modules\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sadeghi\source\repos\MovieTutorial\MovieTutorial\MovieTutorial.Web\Modules\_ViewImports.cshtml"
using MovieTutorial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sadeghi\source\repos\MovieTutorial\MovieTutorial\MovieTutorial.Web\Modules\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sadeghi\source\repos\MovieTutorial\MovieTutorial\MovieTutorial.Web\Modules\_ViewImports.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fc7a84bf1ed1154f23006fdc3b4c9da00b7768d", @"/Modules/BasicSamples/Dialogs/DialogBoxes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c08a75bff74b054ed9b85dddfa46765095830c19", @"/Modules/_ViewImports.cshtml")]
    public class Modules_BasicSamples_Dialogs_DialogBoxes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\sadeghi\source\repos\MovieTutorial\MovieTutorial\MovieTutorial.Web\Modules\BasicSamples\Dialogs\DialogBoxes\Index.cshtml"
  
    ViewData["Title"] = "Dialog Box Types";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("ContentHeader", async() => {
                WriteLiteral("\r\n    <h1>");
#nullable restore
#line 6 "C:\Users\sadeghi\source\repos\MovieTutorial\MovieTutorial\MovieTutorial.Web\Modules\BasicSamples\Dialogs\DialogBoxes\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("<small>Alert, Confirm, Information, Warning</small></h1>\r\n");
            }
            );
            WriteLiteral(@"
<div class=""alert alert-info alert-dismissable"">
    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
    <p>Here are some samples for Q.confirm, Q.alert, Q.information functions</p>
    <p>Click buttons below to launch dialogs.</p>

    <p style=""text-align: right;""><b>Source Files:</b> 
        ");
#nullable restore
#line 15 "C:\Users\sadeghi\source\repos\MovieTutorial\MovieTutorial\MovieTutorial.Web\Modules\BasicSamples\Dialogs\DialogBoxes\Index.cshtml"
   Write(Html.AppSourceFile("Index.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(", \r\n        ");
#nullable restore
#line 16 "C:\Users\sadeghi\source\repos\MovieTutorial\MovieTutorial\MovieTutorial.Web\Modules\BasicSamples\Dialogs\DialogBoxes\Index.cshtml"
   Write(Html.AppSourceFile("DialogBoxes.ts"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </p>
</div>

<button id=""ConfirmDialogButtons"" class=""btn btn-block btn-primary"">Confirm Dialog and Buttons</button>
<button id=""ConfirmWithCustomTitle"" class=""btn btn-block btn-primary"">Confirm With Custom Title</button>
<button id=""Information"" class=""btn btn-block btn-info"">Information</button>
<button id=""Warning"" class=""btn btn-block btn-warning"">Warning</button>
<button id=""Alert"" class=""btn btn-block btn-danger"">Alert</button>
<button id=""AlertWithHtmlContent"" class=""btn btn-block btn-danger"">Alert with HTML Content</button>

<script type=""text/javascript"">
    $(MovieTutorial.BasicSamples.DialogBoxes.initializePage);
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
