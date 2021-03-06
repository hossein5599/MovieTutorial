#pragma checksum "C:\Users\sadeghi\source\repos\MovieTutorial\MovieTutorial\MovieTutorial.Web\Modules\BasicSamples\Grids\TreeGrid\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d137eea12561682a8dee437f7eadd151cfd9d33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_BasicSamples_Grids_TreeGrid_Index), @"mvc.1.0.view", @"/Modules/BasicSamples/Grids/TreeGrid/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d137eea12561682a8dee437f7eadd151cfd9d33", @"/Modules/BasicSamples/Grids/TreeGrid/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c08a75bff74b054ed9b85dddfa46765095830c19", @"/Modules/_ViewImports.cshtml")]
    public class Modules_BasicSamples_Grids_TreeGrid_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\sadeghi\source\repos\MovieTutorial\MovieTutorial\MovieTutorial.Web\Modules\BasicSamples\Grids\TreeGrid\Index.cshtml"
  
    ViewData["Title"] = "Tree Grid";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("ContentHeader", async() => {
                WriteLiteral("\r\n    <h1>");
#nullable restore
#line 6 "C:\Users\sadeghi\source\repos\MovieTutorial\MovieTutorial\MovieTutorial.Web\Modules\BasicSamples\Grids\TreeGrid\Index.cshtml"
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
        It is possible to turn a grid into a tree by using Serenity.TreeGridMixin.
        This mixin requires your items to have a ParentID field. 
    </p>
    <p>
        As we don't have such a field in our order table, we cheat by using modulus 10 and modulus 50.
    </p>

    <p style=""text-align: right;""><b>Source Files:</b> 
        ");
#nullable restore
#line 20 "C:\Users\sadeghi\source\repos\MovieTutorial\MovieTutorial\MovieTutorial.Web\Modules\BasicSamples\Grids\TreeGrid\Index.cshtml"
   Write(Html.AppSourceFile("Index.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(", \r\n        ");
#nullable restore
#line 21 "C:\Users\sadeghi\source\repos\MovieTutorial\MovieTutorial\MovieTutorial.Web\Modules\BasicSamples\Grids\TreeGrid\Index.cshtml"
   Write(Html.AppSourceFile("TreeGrid.ts"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n</div>\r\n\r\n<div id=\"GridDiv\"></div>\r\n\r\n<script type=\"text/javascript\">\r\n    jQuery(function () {\r\n        new MovieTutorial.BasicSamples.TreeGrid($(\'#GridDiv\'), {}).init();\r\n\r\n        Q.initFullHeightGridPage($(\'#GridDiv\'));\r\n    });\r\n</script>");
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
