#pragma checksum "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Acceuil\ReptureStock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d4d445f4b61513d979b066e465be7def33ff6dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Caissier_Views_Acceuil_ReptureStock), @"mvc.1.0.view", @"/Areas/Caissier/Views/Acceuil/ReptureStock.cshtml")]
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
#line 1 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\_ViewImports.cshtml"
using Gestion_Stock;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\_ViewImports.cshtml"
using Gestion_Stock.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d4d445f4b61513d979b066e465be7def33ff6dd", @"/Areas/Caissier/Views/Acceuil/ReptureStock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"129f3bc32af27ae2b4d5fc7be573ce2ef94857eb", @"/Areas/Caissier/Views/_ViewImports.cshtml")]
    public class Areas_Caissier_Views_Acceuil_ReptureStock : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gestion_Stock.Models.ViewModels.IndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<br />\r\n<br />\r\n<br />\r\n<div class=\"backgroundWhite container\">\r\n    <div id=\"menu-filters\" class=\"menu-filter-list list-inline text-center\">\r\n        <span class=\"active btn btn-secondary ml-1 mr-1\" data-filter=\".menu-restaurant\">Show All</span>\r\n");
#nullable restore
#line 8 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Acceuil\ReptureStock.cshtml"
         foreach (var item in Model.Category)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"ml-1 mr-1\" data-filter=\".");
#nullable restore
#line 10 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Acceuil\ReptureStock.cshtml"
                                             Write(item.nom.Replace(" ",string.Empty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 10 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Acceuil\ReptureStock.cshtml"
                                                                                  Write(item.nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 11 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Acceuil\ReptureStock.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <br /><br />\r\n");
#nullable restore
#line 14 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Acceuil\ReptureStock.cshtml"
     foreach (var category in Model.Category)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\" id=\"menu-wrapper\">\r\n");
#nullable restore
#line 17 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Acceuil\ReptureStock.cshtml"
             foreach (var item in @Model.MenuItem.Where(u => u.Categorie.nom.Equals(category.nom)))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-danger col-12\" role=\"alert\">\r\n                    <h4 class=\"alert-heading text-center text-capitalize\">");
#nullable restore
#line 20 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Acceuil\ReptureStock.cshtml"
                                                                     Write(item.nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <p class=\"text-center\">");
#nullable restore
#line 21 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Acceuil\ReptureStock.cshtml"
                                      Write(Html.Raw(item.marque));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <hr>\r\n                    <p class=\"mb-0 text-center\">");
#nullable restore
#line 23 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Acceuil\ReptureStock.cshtml"
                                           Write(item.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n");
#nullable restore
#line 25 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Acceuil\ReptureStock.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 27 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Acceuil\ReptureStock.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.3.1.js""
            integrity=""sha256-2Kok7MbOyxpgUVvAk/HJ2jigOSYS2auK4Pfzbm7uH60=""
            crossorigin=""anonymous""></script>
    <script>var posts = $('.post');
        (function ($) {
            $(""#menu-filters span"").click(function () {
                $(""#menu-filters span"").removeClass('active btn btn-secondary');
                $(this).addClass('active btn btn-secondary');
                var selectedFilter = $(this).data(""filter"");
                $("".menu-restaurant"").fadeOut();
                setTimeout(function () {
                    $(selectedFilter).slideDown();
                }, 300);
            });
        })(jQuery);</script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gestion_Stock.Models.ViewModels.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
