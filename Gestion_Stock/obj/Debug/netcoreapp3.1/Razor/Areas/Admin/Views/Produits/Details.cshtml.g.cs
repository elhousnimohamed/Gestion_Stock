#pragma checksum "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Admin\Views\Produits\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a662aaa568278a583b02bba312c69813d5f0c927"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Produits_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Produits/Details.cshtml")]
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
#line 1 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Admin\Views\_ViewImports.cshtml"
using Gestion_Stock;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Admin\Views\_ViewImports.cshtml"
using Gestion_Stock.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a662aaa568278a583b02bba312c69813d5f0c927", @"/Areas/Admin/Views/Produits/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"129f3bc32af27ae2b4d5fc7be573ce2ef94857eb", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Produits_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gestion_Stock.Models.Produit>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Admin\Views\Produits\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>Details Produit</h1>\r\n\r\n    <div class=\"container\">\r\n        <hr />\r\n\r\n        <table class=\"table shadow-lg p-3 mb-5 bg-white rounded\">\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 16 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Admin\Views\Produits\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 19 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Admin\Views\Produits\Details.cshtml"
               Write(Html.DisplayFor(model => model.nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 24 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Admin\Views\Produits\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Categorie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 27 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Admin\Views\Produits\Details.cshtml"
               Write(Html.DisplayFor(model => model.Categorie.nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 32 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Admin\Views\Produits\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.marque));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Admin\Views\Produits\Details.cshtml"
               Write(Html.DisplayFor(model => model.marque));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 40 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Admin\Views\Produits\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.qte));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Admin\Views\Produits\Details.cshtml"
               Write(Html.DisplayFor(model => model.qte));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 48 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Admin\Views\Produits\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.dateStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Admin\Views\Produits\Details.cshtml"
               Write(Html.DisplayFor(model => model.dateStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 56 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Admin\Views\Produits\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.livre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Admin\Views\Produits\Details.cshtml"
               Write(Html.DisplayFor(model => model.livre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 65 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Admin\Views\Produits\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Admin\Views\Produits\Details.cshtml"
               Write(Html.DisplayFor(model => model.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n\r\n\r\n\r\n\r\n        </table>\r\n\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a662aaa568278a583b02bba312c69813d5f0c9279814", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Admin\Views\Produits\Details.cshtml"
                                               WriteLiteral(Model.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a662aaa568278a583b02bba312c69813d5f0c92712082", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gestion_Stock.Models.Produit> Html { get; private set; }
    }
}
#pragma warning restore 1591