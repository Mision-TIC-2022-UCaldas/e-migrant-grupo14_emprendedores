using System;
using System.Collections.Generic;
using E_Migrant.App.Dominio;
namespace E_Migrant.App.Persistencia
{
    public interface IRepositorioRegistroOfertaServicio
    {
        RegistroOfertaServicios addRegistroOfertaServicio(
            string NombreServicio,
            int NumeroMaximoMigrantes,
            DateTime InicioOfertaServicio,
            DateTime FinOfertaServicio,
            TipoEstadoServicio EstadoServicio
        );
    }
}