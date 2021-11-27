using System;
namespace E_Migrant.App.Dominio
{
    public class Migrante
    {
        public int id {get; set;}
        public string nombre {get; set;}
        public string apellidos {get; set;}
        public int tipoIdentificacion {get; set;} 
        public string numeroIdentificacion {get; set;}
        public string pais {get; set;}
        public DateTime fechaNacimiento {get;set;}
        public string correoElectronico {get;set;}
        public string numeroTelefonico {get; set;}
        public string direccionActual {get;set;}
        public string ciudad {get; set;}
        public string situacionLaboral {get; set;}

    }
}