#pragma checksum "C:\Users\sadeghi\source\repos\MovieTutorial\MovieTutorial\MovieTutorial.Web\Modules\BasicSamples\Grids\WrappedHeaders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c654516ac02c915cb8b279a658a305254b27fce3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_BasicSamples_Grids_WrappedHeaders_Index), @"mvc.1.0.view", @"/Modules/BasicSamples/Grids/WrappedHeaders/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c654516ac02c915cb8b279a658a305254b27fce3", @"/Modules/BasicSamples/Grids/WrappedHeaders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c08a75bff74b054ed9b85dddfa46765095830c19", @"/Modules/_ViewImports.cshtml")]
    public class Modules_BasicSamples_Grids_WrappedHeaders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\sadeghi\source\repos\MovieTutorial\MovieTutorial\MovieTutorial.Web\Modules\BasicSamples\Grids\WrappedHeaders\Index.cshtml"
  
    ViewData["Title"] = "Wrapped Headers";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("ContentHeader", async() => {
                WriteLiteral("\r\n    <h1>");
#nullable restore
#line 6 "C:\Users\sadeghi\source\repos\MovieTutorial\MovieTutorial\MovieTutorial.Web\Modules\BasicSamples\Grids\WrappedHeaders\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("<small></small></h1>\r\n");
            }
            );
            WriteLiteral(@"
<div class=""alert alert-info alert-dismissable"">
    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
    <p>
        Sometimes you might want to wrap column headers in grid. For this you just need to set a few CSS rules.
    </p>
    <p>
        site.basicsamples.less for class .s-WrappedHeadersGrid.
        See rules in ");
#nullable restore
#line 16 "C:\Users\sadeghi\source\repos\MovieTutorial\MovieTutorial\MovieTutorial.Web\Modules\BasicSamples\Grids\WrappedHeaders\Index.cshtml"
                Write(Html.AppSourceFile(@"..\..\..\..\Content\site\site.basicsamples.less"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" for how.\r\n    </p>\r\n\r\n    <p style=\"text-align: right;\"><b>Source Files:</b> \r\n        ");
#nullable restore
#line 20 "C:\Users\sadeghi\source\repos\MovieTutorial\MovieTutorial\MovieTutorial.Web\Modules\BasicSamples\Grids\WrappedHeaders\Index.cshtml"
   Write(Html.AppSourceFile("Index.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(", \r\n        ");
#nullable restore
#line 21 "C:\Users\sadeghi\source\repos\MovieTutorial\MovieTutorial\MovieTutorial.Web\Modules\BasicSamples\Grids\WrappedHeaders\Index.cshtml"
   Write(Html.AppSourceFile("WrappedHeadersGrid.ts"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 22 "C:\Users\sadeghi\source\repos\MovieTutorial\MovieTutorial\MovieTutorial.Web\Modules\BasicSamples\Grids\WrappedHeaders\Index.cshtml"
   Write(Html.AppSourceFile(@"..\..\..\..\Content\site\site.basicsamples.less"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </p>
</div>

<div id=""GridDiv""></div>

<script type=""text/javascript"">
    jQuery(function () {
        new MovieTutorial.BasicSamples.WrappedHeadersGrid($('#GridDiv'), {}).init();

        Q.initFullHeightGridPage($('#GridDiv'));
    });
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
