#pragma checksum "C:\Users\sadeghi\source\repos\MovieTutorial\MovieTutorial\MovieTutorial.Web\Modules\MovieDB\MovieGenres\MovieGenresIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac30c72ab89480c2dd2bbbb386698449c679ffd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_MovieDB_MovieGenres_MovieGenresIndex), @"mvc.1.0.view", @"/Modules/MovieDB/MovieGenres/MovieGenresIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac30c72ab89480c2dd2bbbb386698449c679ffd3", @"/Modules/MovieDB/MovieGenres/MovieGenresIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c08a75bff74b054ed9b85dddfa46765095830c19", @"/Modules/_ViewImports.cshtml")]
    public class Modules_MovieDB_MovieGenres_MovieGenresIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sadeghi\source\repos\MovieTutorial\MovieTutorial\MovieTutorial.Web\Modules\MovieDB\MovieGenres\MovieGenresIndex.cshtml"
  
    ViewData["Title"] = Localizer.Get("Db.MovieDB.MovieGenres.EntityPlural");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"GridDiv\"></div>\r\n\r\n<script type=\"text/javascript\">\r\n    jQuery(function () {\r\n        new MovieTutorial.MovieDB.MovieGenresGrid($(\'#GridDiv\'), {}).init();\r\n\r\n        Q.initFullHeightGridPage($(\'#GridDiv\'));\r\n    });\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Serenity.ITextLocalizer Localizer { get; private set; }
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
