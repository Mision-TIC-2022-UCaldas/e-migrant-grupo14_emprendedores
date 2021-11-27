//using System;
namespace E_Migrant.App.Dominio
{
    public class ConsultaHistorial
    {
        public DateTime fechaSolicitud{get;set;}
        public DateTime fechaAceptacionRechazo{get;set;}
        public string descripcionServicio{get;set;}
        public string entidadQueLoOfrece{get;set;}
        public TipoEstado estado{get;set;}
    }
}