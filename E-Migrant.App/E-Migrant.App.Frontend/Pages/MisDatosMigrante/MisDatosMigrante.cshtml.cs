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



namespace E_Migrant.App.Frontend.Pages.MisDatosMigrante
{
    public class MisDatosMigranteModel : PageModel
    {   
        

        
        /*private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;*/
        //public readonly Persistencia.IRepositorioDatosMigrante repositorioDatosMigrante;>
        /*public MisDatosMigranteModel(){
                
            this.repositorioDatosMigrante = new RepositorioDatosMigrante(new E_Migrant.App.Persistencia.AppContext());
            }*/
            private static IRepositorioDatosMigrante _repoMigrante = new RepositorioDatosMigrante(new Persistencia.AppContext());
          public Migrante migrante { get; set; }
        public IActionResult OnGet(string correo){
             
             migrante= _repoMigrante.GetDatosMigranteCoreo(correo);
            if(migrante==null){
               return RedirectToPage("../Error");
            }else{
                return Page();
            }
        
    }
}
}

