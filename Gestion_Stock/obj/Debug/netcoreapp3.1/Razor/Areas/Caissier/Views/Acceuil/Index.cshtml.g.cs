#pragma checksum "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Acceuil\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba66d3e6a09d3b255d37148c9d178be2e7c8a2c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Caissier_Views_Acceuil_Index), @"mvc.1.0.view", @"/Areas/Caissier/Views/Acceuil/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba66d3e6a09d3b255d37148c9d178be2e7c8a2c1", @"/Areas/Caissier/Views/Acceuil/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"129f3bc32af27ae2b4d5fc7be573ce2ef94857eb", @"/Areas/Caissier/Views/_ViewImports.cshtml")]
    public class Areas_Caissier_Views_Acceuil_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gestion_Stock.Models.ViewModels.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ThumbnailAreaPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<br />\r\n<br />\r\n<br />\r\n<div class=\"backgroundWhite container\">\r\n    <div id=\"menu-filters\" class=\"menu-filter-list list-inline text-center\">\r\n        <span class=\"active btn btn-secondary ml-1 mr-1\" data-filter=\".menu-restaurant\">Show All</span>\r\n");
#nullable restore
#line 8 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Acceuil\Index.cshtml"
         foreach (var item in Model.Category)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"ml-1 mr-1\" data-filter=\".");
#nullable restore
#line 10 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Acceuil\Index.cshtml"
                                             Write(item.nom.Replace(" ",string.Empty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 10 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Acceuil\Index.cshtml"
                                                                                  Write(item.nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 11 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Acceuil\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 13 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Acceuil\Index.cshtml"
     foreach (var category in Model.Category)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\" id=\"menu-wrapper\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ba66d3e6a09d3b255d37148c9d178be2e7c8a2c15306", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 16 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Acceuil\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.MenuItem.Where(u=>u.Categorie.nom.Equals(category.nom));

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 18 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Acceuil\Index.cshtml"
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
