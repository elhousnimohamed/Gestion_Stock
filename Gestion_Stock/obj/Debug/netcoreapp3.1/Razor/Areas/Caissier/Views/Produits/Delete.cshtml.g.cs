#pragma checksum "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Produits\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a6aa4417e1f4b4775b2b581733f412a06ec5b49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Caissier_Views_Produits_Delete), @"mvc.1.0.view", @"/Areas/Caissier/Views/Produits/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a6aa4417e1f4b4775b2b581733f412a06ec5b49", @"/Areas/Caissier/Views/Produits/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"129f3bc32af27ae2b4d5fc7be573ce2ef94857eb", @"/Areas/Caissier/Views/_ViewImports.cshtml")]
    public class Areas_Caissier_Views_Produits_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gestion_Stock.Models.Produit>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Produits\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n\r\n<div class=\"container\">\r\n    <hr />\r\n\r\n    <table class=\"table shadow-lg p-3 mb-5 bg-white rounded\">\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Produits\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
#nullable restore
#line 21 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Produits\Delete.cshtml"
           Write(Html.DisplayFor(model => model.nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Produits\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Categorie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
#nullable restore
#line 29 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Produits\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Categorie.nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Produits\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.marque));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Produits\Delete.cshtml"
           Write(Html.DisplayFor(model => model.marque));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 42 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Produits\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.qte));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Produits\Delete.cshtml"
           Write(Html.DisplayFor(model => model.qte));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Produits\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.dateStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Produits\Delete.cshtml"
           Write(Html.DisplayFor(model => model.dateStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 58 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Produits\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.livre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Produits\Delete.cshtml"
           Write(Html.DisplayFor(model => model.livre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 67 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Produits\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Produits\Delete.cshtml"
           Write(Html.DisplayFor(model => model.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n\r\n\r\n\r\n\r\n    </table>\r\n\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a6aa4417e1f4b4775b2b581733f412a06ec5b499965", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0a6aa4417e1f4b4775b2b581733f412a06ec5b4910235", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 81 "C:\Users\ab\source\repos\Gestion_Stock\Gestion_Stock\Areas\Caissier\Views\Produits\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a6aa4417e1f4b4775b2b581733f412a06ec5b4912047", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n");
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
