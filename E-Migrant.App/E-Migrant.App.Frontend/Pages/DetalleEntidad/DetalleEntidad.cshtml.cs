using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E_Migrant.App.Dominio;
using E_Migrant.App.Persistencia;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace E_Migrant.App.Frontend.Pages.DetalleEntidadModel
{
    public class DetalleEntidadModel : PageModel
    {
        private static IRepositorioDatosEntidadesColaboradoras _repoDatosEnti = new RepositorioDatosEntidadesColaboradores(new Persistencia.AppContext());
        public DatosEntidadesColaboradoras  datosEntidadesColaboradoras { get; set; }
        

        public IActionResult OnGet(string nit)
        {    
            if(nit!=null){
                datosEntidadesColaboradoras = _repoDatosEnti.GetDatosDeLaEntidad(nit);
                return Page();
            }
             return RedirectToPage("../Error");
        }
    }
}
