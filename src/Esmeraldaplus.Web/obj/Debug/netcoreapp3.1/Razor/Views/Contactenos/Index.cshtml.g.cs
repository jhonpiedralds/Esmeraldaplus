#pragma checksum "C:\Users\Juan José\OneDrive\Escritorio\Esmeraldaplus1-master\src\Esmeraldaplus.Web\Views\Contactenos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ade70ad505f195a7d3ef49bae625d510d03e4a23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contactenos_Index), @"mvc.1.0.view", @"/Views/Contactenos/Index.cshtml")]
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
#line 1 "C:\Users\Juan José\OneDrive\Escritorio\Esmeraldaplus1-master\src\Esmeraldaplus.Web\Views\_ViewImports.cshtml"
using Esmeraldaplus.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Juan José\OneDrive\Escritorio\Esmeraldaplus1-master\src\Esmeraldaplus.Web\Views\_ViewImports.cshtml"
using Esmeraldaplus.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ade70ad505f195a7d3ef49bae625d510d03e4a23", @"/Views/Contactenos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b317339fd9e601d704002137289583b7d35d351", @"/Views/_ViewImports.cshtml")]
    public class Views_Contactenos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/contact.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\Juan José\OneDrive\Escritorio\Esmeraldaplus1-master\src\Esmeraldaplus.Web\Views\Contactenos\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/plantilla.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("home", async() => {
                WriteLiteral(" \n<link rel=\"stylesheet\" href=\"../css/contact.css\">\n");
            }
            );
            WriteLiteral("\n\n\n<div class=\"menu\">\n    <span class=\"icon-menu\"> Menu</span>\n</div>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ade70ad505f195a7d3ef49bae625d510d03e4a234793", async() => {
                WriteLiteral("\n    <h1>Contacto</h1>\n    <input type=\"text\" name=\"Nombre-Cliente\" placeholder=\"Nombres\"");
                BeginWriteAttribute("required", " required=\"", 333, "\"", 344, 0);
                EndWriteAttribute();
                WriteLiteral(">\n    <input type=\"email\" name=\"Correo\" placeholder=\"Correo\"");
                BeginWriteAttribute("required", " required=\"", 405, "\"", 416, 0);
                EndWriteAttribute();
                WriteLiteral(">\n    <input type=\"text\" name=\"Telefono\" placeholder=\"Telefono\"");
                BeginWriteAttribute("required", " required=\"", 480, "\"", 491, 0);
                EndWriteAttribute();
                WriteLiteral(">\n    <textarea name=\"mensaje\" placeholder=\"Ingrese aqui su mensaje\"");
                BeginWriteAttribute("required", " required=\"", 560, "\"", 571, 0);
                EndWriteAttribute();
                WriteLiteral("></textarea>\n    <input type=\"submit\" value=\"Enviar\" id=\"boton\">\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div class=""mapa"">
    <h1>Ubicacion</h1>
    <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3976.745965330832!2d-74.16063678573687!3d4.639344643479545!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x8e3f9c3ababaf9d5%3A0x72efa6111527e06c!2zQ2wuIDIgIzg2LCBCb2dvdMOh!5e0!3m2!1ses!2sco!4v1606875074020!5m2!1ses!2sco"" width=""470"" height=""380"" frameborder=""0"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 1043, "\"", 1061, 0);
            EndWriteAttribute();
            WriteLiteral(" aria-hidden=\"false\" tabindex=\"0\"></iframe>\n</div>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ade70ad505f195a7d3ef49bae625d510d03e4a237745", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
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
