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

namespace E_Migrant.App.Frontend.Pages.DetallesMigrante
{
    public class DetallesMigranteModel : PageModel
    {
        private static IRepositorioDatosMigrante _repoMigrante = new RepositorioDatosMigrante(new Persistencia.AppContext());
        public Migrante migrante { get; set; }
        public IActionResult OnGet(int id)
        {
             if(id!=0){
                migrante = _repoMigrante.GetMigranteid(id);
                return Page();
            }
             return RedirectToPage("../Error");
        }
    }
}
