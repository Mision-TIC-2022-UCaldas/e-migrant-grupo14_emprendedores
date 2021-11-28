using System;
using System.ComponentModel.DataAnnotations;

namespace E_Migrant.App.Dominio{

    public class DatosEntidadesColaboradoras{
        public int id {get; set;}

        [Required]        
        public string razonSocial {get; set;}
        [Required] 
        public string nit {get; set;}
        [Required] 
        public string direccion {get; set;}
        [Required] 
        public string ciudad {get; set;}
        [Required] 
        public string Telefono {get; set;}
        [EmailAddress]
        public string correoElectronico {get; set;}
        
        public string paginaWeb {get; set;}
        [Required] 
        public string sector {get; set;}
        [Required] 
        public string serviciosOfrece {get;set;}
        
    }
}