#pragma checksum "C:\Users\Exneider\Desktop\Hackaton\e-migrant-grupo14_emprendedores\E-Migrant.App\E-Migrant.App.Frontend\Pages\ListadoEntidades\ListadoEntidades.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48259e15337dc965629fbb312dddef946cafc462"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(E_Migrant.App.Frontend.Pages.ListadoEntidades.Pages_ListadoEntidades_ListadoEntidades), @"mvc.1.0.razor-page", @"/Pages/ListadoEntidades/ListadoEntidades.cshtml")]
namespace E_Migrant.App.Frontend.Pages.ListadoEntidades
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
#line 1 "C:\Users\Exneider\Desktop\Hackaton\e-migrant-grupo14_emprendedores\E-Migrant.App\E-Migrant.App.Frontend\Pages\_ViewImports.cshtml"
using E_Migrant.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48259e15337dc965629fbb312dddef946cafc462", @"/Pages/ListadoEntidades/ListadoEntidades.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b064261e4a6778155f5e1d205d3aeef257a1477", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ListadoEntidades_ListadoEntidades : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Filtro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float: right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48259e15337dc965629fbb312dddef946cafc4624683", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                Nit: ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "48259e15337dc965629fbb312dddef946cafc4625004", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 8 "C:\Users\Exneider\Desktop\Hackaton\e-migrant-grupo14_emprendedores\E-Migrant.App\E-Migrant.App.Frontend\Pages\ListadoEntidades\ListadoEntidades.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Filtro);

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
                WriteLiteral("\r\n                <input type=\"submit\" value=\"Filtrar\" />\r\n            </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<table class=""table"">
    <thead>
        <tr>
            <th >id</th>
            <th>Razon Social</th>
            <th>NIT</th>
            <th>Dirección</th>
            <th>Telefono</th>
            <th>email</th>
            <th>Pagina web</th>
            <th>ciudad</th>
            <th>Sector</th>
            <th>Tipo Servicio</th>
        </tr>
    </thead>
");
#nullable restore
#line 28 "C:\Users\Exneider\Desktop\Hackaton\e-migrant-grupo14_emprendedores\E-Migrant.App\E-Migrant.App.Frontend\Pages\ListadoEntidades\ListadoEntidades.cshtml"
    foreach (var entidad in Model.datosEntidadesColaboradoras)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td >");
#nullable restore
#line 31 "C:\Users\Exneider\Desktop\Hackaton\e-migrant-grupo14_emprendedores\E-Migrant.App\E-Migrant.App.Frontend\Pages\ListadoEntidades\ListadoEntidades.cshtml"
            Write(entidad.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\Exneider\Desktop\Hackaton\e-migrant-grupo14_emprendedores\E-Migrant.App\E-Migrant.App.Frontend\Pages\ListadoEntidades\ListadoEntidades.cshtml"
           Write(entidad.razonSocial);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\Exneider\Desktop\Hackaton\e-migrant-grupo14_emprendedores\E-Migrant.App\E-Migrant.App.Frontend\Pages\ListadoEntidades\ListadoEntidades.cshtml"
           Write(entidad.nit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\Exneider\Desktop\Hackaton\e-migrant-grupo14_emprendedores\E-Migrant.App\E-Migrant.App.Frontend\Pages\ListadoEntidades\ListadoEntidades.cshtml"
           Write(entidad.direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\Exneider\Desktop\Hackaton\e-migrant-grupo14_emprendedores\E-Migrant.App\E-Migrant.App.Frontend\Pages\ListadoEntidades\ListadoEntidades.cshtml"
           Write(entidad.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\Exneider\Desktop\Hackaton\e-migrant-grupo14_emprendedores\E-Migrant.App\E-Migrant.App.Frontend\Pages\ListadoEntidades\ListadoEntidades.cshtml"
           Write(entidad.correoElectronico);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\Exneider\Desktop\Hackaton\e-migrant-grupo14_emprendedores\E-Migrant.App\E-Migrant.App.Frontend\Pages\ListadoEntidades\ListadoEntidades.cshtml"
           Write(entidad.paginaWeb);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\Exneider\Desktop\Hackaton\e-migrant-grupo14_emprendedores\E-Migrant.App\E-Migrant.App.Frontend\Pages\ListadoEntidades\ListadoEntidades.cshtml"
           Write(entidad.ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 39 "C:\Users\Exneider\Desktop\Hackaton\e-migrant-grupo14_emprendedores\E-Migrant.App\E-Migrant.App.Frontend\Pages\ListadoEntidades\ListadoEntidades.cshtml"
           Write(entidad.sector);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 40 "C:\Users\Exneider\Desktop\Hackaton\e-migrant-grupo14_emprendedores\E-Migrant.App\E-Migrant.App.Frontend\Pages\ListadoEntidades\ListadoEntidades.cshtml"
           Write(entidad.serviciosOfrece);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 42 "C:\Users\Exneider\Desktop\Hackaton\e-migrant-grupo14_emprendedores\E-Migrant.App\E-Migrant.App.Frontend\Pages\ListadoEntidades\ListadoEntidades.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<E_Migrant.App.Frontend.Pages.ListadoEntidades.ListadoEntidadesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<E_Migrant.App.Frontend.Pages.ListadoEntidades.ListadoEntidadesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<E_Migrant.App.Frontend.Pages.ListadoEntidades.ListadoEntidadesModel>)PageContext?.ViewData;
        public E_Migrant.App.Frontend.Pages.ListadoEntidades.ListadoEntidadesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
