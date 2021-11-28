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

namespace E_Migrant.App.Frontend
{

    public class RegistrarDatosEntidadModel : PageModel
    {

        private static IRepositorioDatosEntidadesColaboradoras _repoDatosEnti = new RepositorioDatosEntidadesColaboradores(new Persistencia.AppContext());
        public DatosEntidadesColaboradoras datosEntidadesColaboradoras { get; set; }
        public IActionResult OnPost(DatosEntidadesColaboradoras datosEntidadesColaboradoras)
        {
            var DatosEntidadEncontrado = _repoDatosEnti.GetDatosEntidadNit(datosEntidadesColaboradoras.nit);

            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                if (DatosEntidadEncontrado)
                {
                    return RedirectToPage("../Error");
                }else
                {
                    var adicionando = _repoDatosEnti.AddDatosEntidades(datosEntidadesColaboradoras);
                    if (adicionando == null)
                    {
                        return RedirectToPage("../Error");
                    }
                    else
                    {
                        datosEntidadesColaboradoras = adicionando;

                    }
                }

                return RedirectToPage("../index");
            }
        }
    }





}
