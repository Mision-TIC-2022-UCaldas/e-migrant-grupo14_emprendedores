using System;
//using TipoEstadoConsultaServicios;
namespace E_Migrant.App.Dominio
{
    public class ConsultaServicios
    {
        public int total { get; set; }
        public DateTime fechaInicioServicio{get;set;}
        public TipoEstadoConsultaServicios estadoConsultaServicio{get;set;}
    }
}