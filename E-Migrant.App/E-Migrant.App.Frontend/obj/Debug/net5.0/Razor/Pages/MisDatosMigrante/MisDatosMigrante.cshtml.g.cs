#pragma checksum "C:\Users\Exneider\Desktop\Hackaton\e-migrant-grupo14_emprendedores\E-Migrant.App\E-Migrant.App.Frontend\Pages\MisDatosMigrante\MisDatosMigrante.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02a54e6b0efc18d08217025488f2306ece4b334d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(E_Migrant.App.Frontend.Pages.MisDatosMigrante.Pages_MisDatosMigrante_MisDatosMigrante), @"mvc.1.0.razor-page", @"/Pages/MisDatosMigrante/MisDatosMigrante.cshtml")]
namespace E_Migrant.App.Frontend.Pages.MisDatosMigrante
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
#nullable restore
#line 5 "C:\Users\Exneider\Desktop\Hackaton\e-migrant-grupo14_emprendedores\E-Migrant.App\E-Migrant.App.Frontend\Pages\MisDatosMigrante\MisDatosMigrante.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Exneider\Desktop\Hackaton\e-migrant-grupo14_emprendedores\E-Migrant.App\E-Migrant.App.Frontend\Pages\MisDatosMigrante\MisDatosMigrante.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Exneider\Desktop\Hackaton\e-migrant-grupo14_emprendedores\E-Migrant.App\E-Migrant.App.Frontend\Pages\MisDatosMigrante\MisDatosMigrante.cshtml"
using E_Migrant.App.Persistencia;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02a54e6b0efc18d08217025488f2306ece4b334d", @"/Pages/MisDatosMigrante/MisDatosMigrante.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b064261e4a6778155f5e1d205d3aeef257a1477", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MisDatosMigrante_MisDatosMigrante : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02a54e6b0efc18d08217025488f2306ece4b334d4154", async() => {
                WriteLiteral("\r\n    <div class=\"col-md-12\">\r\n\r\n        <label for=\"nombre\" class=\"form-label\">nombres</label>\r\n        <input");
                BeginWriteAttribute("value", " value=\"", 416, "\"", 454, 1);
#nullable restore
#line 16 "C:\Users\Exneider\Desktop\Hackaton\e-migrant-grupo14_emprendedores\E-Migrant.App\E-Migrant.App.Frontend\Pages\MisDatosMigrante\MisDatosMigrante.cshtml"
WriteAttributeValue("", 424, UserManager.GetUserName(User), 424, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" asp-area=\"Identity\" type=\"text\"  class=\"form-control\"\r\n            id=\"nombre\" />\r\n        <div class=\"invalid-feedback\">Este campo es requerido</div>\r\n    </div>\r\n    <div class=\"col-md-12\">\r\n\r\n        <h1>");
#nullable restore
#line 22 "C:\Users\Exneider\Desktop\Hackaton\e-migrant-grupo14_emprendedores\E-Migrant.App\E-Migrant.App.Frontend\Pages\MisDatosMigrante\MisDatosMigrante.cshtml"
       Write(Model.migrante.nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" Hola</h1>
        
        
    </div>

    <!--
            <div class=""col-md-12"">
                <label for=""apellidos"" class=""form-label"">Apellidos</label>
                <input type=""text"" asp-for=""Input.apellido"" class=""form-control"" id=""apellidos""  required />
                <div class=""invalid-feedback"">Este campo es requerido</div>
            </div>
            <div class=""col-md-12"">
                <label for=""pais"" class=""form-label"">País</label>
                <input type=""text"" asp-for=""Input.pais"" class=""form-control"" id=""pais"" required />
                <div class=""invalid-feedback"">Este campo es requerido</div>
            </div>
            <div class=""col-md-6 mt-4"">
                    <select class= aria-label=""Default select example"" asp-for=""Input.TipoDocumento"" required>

                        <option selected >Tipo Documento</option>
                        <option value=""0"">Tarjeta identidad</option>
                        <option value=""1"">cedula extra");
                WriteLiteral(@"njeria</option>
                        <option value=""2"">Pasaporte</option>
                        <option value=""3"">otro</option>
                    </select>
                    <div class=""invalid-feedback"">Este campo es requerido</div>
            </div>
            <div class=""col-md-6"">
                <label for=""numeroDocumento"" class=""form-label"">Identificación</label>
                <input asp-for=""Input.numeroDocumento"" type=""text"" class=""form-control"" id=""numeroIdentificacion""  required />
                <div class=""invalid-feedback"">Este campo es requerido</div>
            </div>
            <div class=""col-md-12"">
                <label for=""ciudad"" class=""form-label"">Ciudad</label>
                <input asp-for=""Input.ciudad"" type=""text"" class=""form-control"" id=""ciudad"" />
            </div>
            <div class=""col-md-12"">
                <label for=""cituacionLaboral"" class=""form-label"">Situación laboral</label>
                <input asp-for=""Input.SituacionLaboral""");
                WriteLiteral(@" type=""text"" class=""form-control"" id=""cituacionLaboral"" name=""situacionLaboral"" />
            </div>
            <div class=""col-md-12"">
                <label for=""txtDireccionActual"" class=""form-label"">Dirección Actual</label>
                <input asp-for=""Input.DireccionActual"" type=""text"" class=""form-control"" id=""txtDireccionActual""  />
            </div>

            <div class=""col-md-12"">
                <label for=""txtCelular"" class=""form-label"">Numero Telefonico</label>
                <input type=""text"" class=""form-control"" id=""txtCelular"" />
            </div>
            <div class=""col-md-12"">
                <label for=""fechaNacimiento"" class=""form-label"">Fecha Nacimiento</label>
                <input asp-for=""Input.fechaNacimiento"" type=""text"" class=""form-control"" id=""fechaNacimiento"" required />
                <div class=""invalid-feedback"">Este campo es requerido</div>
            </div>
            -->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<E_Migrant.App.Frontend.Pages.MisDatosMigrante.MisDatosMigranteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<E_Migrant.App.Frontend.Pages.MisDatosMigrante.MisDatosMigranteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<E_Migrant.App.Frontend.Pages.MisDatosMigrante.MisDatosMigranteModel>)PageContext?.ViewData;
        public E_Migrant.App.Frontend.Pages.MisDatosMigrante.MisDatosMigranteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
