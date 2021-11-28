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

namespace E_Migrant.App.Frontend.Pages.ListadoEntidades
{
    public class ListadoEntidadesModel : PageModel
    {
        private static IRepositorioDatosEntidadesColaboradoras _repoDatosEnti = new RepositorioDatosEntidadesColaboradores(new Persistencia.AppContext());
        public IEnumerable<DatosEntidadesColaboradoras>  datosEntidadesColaboradoras { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Filtro {get;set;}
        public void OnGet(string filtro)
        {    
            Filtro=filtro;
            //datosEntidadesColaboradoras = _repoDatosEnti.GetAllEntidades();
            datosEntidadesColaboradoras = _repoDatosEnti.GetDatosEntidadNitFiltro(filtro);
        }
        
    }
}
