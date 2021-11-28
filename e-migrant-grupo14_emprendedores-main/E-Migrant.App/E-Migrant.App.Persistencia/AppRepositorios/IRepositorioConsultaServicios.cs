using System;
using System.Collections.Generic;
using E_Migrant.App.Dominio;
namespace E_Migrant.App.Persistencia
{
    public interface IRepositorioConsultaServicios
    {
        ConsultaServicios addConsultaServicios(
        int Total,
        DateTime FechaInicioServicio,
        TipoEstadoServicio EstadoServicio
        );
    }
}