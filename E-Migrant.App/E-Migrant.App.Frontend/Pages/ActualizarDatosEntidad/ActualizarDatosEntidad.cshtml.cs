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

        public IActionResult OnGet(int id)
        {

            if (id != 0)
            {
                datosEntidadesColaboradoras = _repoDatosEnti.GetDatosDeLaEntidadId(id);
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

                if (datosEntidadesColaboradoras.id > 0)
                {
                    _repoDatosEnti.updateDatosEntidad(datosEntidadesColaboradoras);
                }
                return RedirectToPage("../Index");
            }
            else
            {
                return RedirectToPage("../Error");
            }
        }
        
    }
}
