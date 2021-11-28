using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using E_Migrant.App.Dominio;
using E_Migrant.App.Persistencia;

namespace E_Migrant.App.Frontend.Pages.ActualizarDatosEntidadModel
{
    public class ActualizarDatosEntidadModel : PageModel
    {
        private static IRepositorioDatosEntidadesColaboradoras _repoDatosEnti = new RepositorioDatosEntidadesColaboradores(new Persistencia.AppContext());
        public DatosEntidadesColaboradoras datosEntidadesColaboradoras { get; set; }

        public IActionResult OnGet(string nit)
        {

            if (nit != "")
            {
                datosEntidadesColaboradoras = _repoDatosEnti.GetDatosDeLaEntidad(nit);
            }
            else
            {

                datosEntidadesColaboradoras= new DatosEntidadesColaboradoras();
            }
            // migrante= _repoMigrante.GetDatosMigranteCoreo(correo);
            if (datosEntidadesColaboradoras == null)
            {
                return RedirectToPage("../Error");
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(DatosEntidadesColaboradoras datosEntidadesColaboradoras)
        {
            if (ModelState.IsValid)
            {

                if (datosEntidadesColaboradoras.nit == "")
                {
                    _repoDatosEnti.updateDatosEntidad(datosEntidadesColaboradoras);
                }
                return Page();
            }
            else
            {
                return RedirectToPage("../Error");
            }
        }
    }
}
