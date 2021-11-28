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

namespace E_Migrant.App.Frontend.Pages.ListadoMigrante
{
    public class ListadoMigranteModel : PageModel
    {
        private static IRepositorioDatosMigrante _repoDatosMigrante = new RepositorioDatosMigrante(new Persistencia.AppContext());
        public IEnumerable<Migrante>  migrante { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Filtro {get;set;}
        public void OnGet( string filtro)
        {
            Filtro=filtro;
            //datosEntidadesColaboradoras = _repoDatosEnti.GetAllEntidades();
            migrante = _repoDatosMigrante.GetDatosMigrantesFiltro(filtro); 
        }
    }
}
