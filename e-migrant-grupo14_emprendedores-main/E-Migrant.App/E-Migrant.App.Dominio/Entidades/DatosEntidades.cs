//using System;
namespace E_Migrant.App.Dominio
{
    public class DatosEntidades
    {
        public string razonSocial{get;set;}

        public string nit{get;set;}

        public string direccion{get;set;}

        public string ciudad{get;set;}

        public string telefono{get;set;}

        public string direccionElectronica{get;set;}

        public string paginaWeb{get;set;}

        public Sector sector{get;set;}

        public TipoServicioOfrecido servicioQueOfrece{get;set;}
    }
}