using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E_Migrant.App.Dominio;
using E_Migrant.App.Persistencia;
namespace E_Migrant.App.Frontend.Pages
{
    public class RegistroDatosMigra : PageModel
    {
        public readonly Persistencia.IRepositorioDatosMigrante repositorioDatosMigrante;
        [BindProperty]
        public Migrante migrante { get; set; }

        public RegistroDatosMigra()
        {
            this.repositorioDatosMigrante = new RepositorioDatosMigrante(new E_Migrant.App.Persistencia.AppContext());
        }
        
        string nombre { get; set; }
        string apellidos { get; set; }
        tipoIdentificacion tipoIdentificacion { get; set; }
        string numeroIdentificacion { get; set; }
        string pais { get; set; }
        DateTime fechaNacimiento { get; set; }
        string correoElectronico { get; set; }
        string numeroTelefonico { get; set; }
        string direccionActual { get; set; }
        string ciudad { get; set; }
        string situacionLaboral { get; set; }
        public IActionResult OnPost(string nombre,string apellidos,tipoIdentificacion tipoIdentificacion,
        string numeroIdentificacion,  string pais, DateTime fechaNacimiento, string correoElectronico,
        string numeroTelefonico , string direccionActual , string ciudad, string situacionLaboral )
        {
        this.nombre= nombre;
        this.apellidos=apellidos;
        this.tipoIdentificacion=tipoIdentificacion;
        this.numeroIdentificacion=numeroIdentificacion;
        this.pais=pais;
        this.fechaNacimiento=fechaNacimiento;
        this.correoElectronico=correoElectronico;
        this.numeroTelefonico=numeroIdentificacion;
        this.direccionActual=direccionActual;
        this.ciudad=ciudad;
        this.situacionLaboral=situacionLaboral;
        migrante = repositorioDatosMigrante.AddDatosMigrante(nombre, apellidos,tipoIdentificacion,
         numeroIdentificacion, pais, fechaNacimiento, correoElectronico,
         numeroTelefonico, direccionActual, ciudad, situacionLaboral);
        
            if(migrante==null){
                return Page();
            }else{
                return Redirect("../Index");
            }

        }
    }
}
