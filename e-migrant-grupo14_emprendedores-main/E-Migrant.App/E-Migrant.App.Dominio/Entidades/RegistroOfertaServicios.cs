using System;
//using TipoEstadoServicio;
namespace E_Migrant.App.Dominio
{
    public class RegistroOfertaServicios
    {
        public string nombreServicio { get; set; }
        public int numeroMaximoMigrantes { get; set; }
        public DateTime inicioOfertaServicio { get; set; }
        public DateTime finOfertaServicio { get; set; }
        public TipoEstadoServicio estadoServicio { get; set; }
    }
}