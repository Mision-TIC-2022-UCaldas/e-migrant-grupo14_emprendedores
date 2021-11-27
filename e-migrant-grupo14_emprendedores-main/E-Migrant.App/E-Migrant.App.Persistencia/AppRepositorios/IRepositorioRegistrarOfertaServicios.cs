using System;
using System.Collections.Generic;
using E_Migrant.App.Dominio;
namespace E_Migrant.App.Persistencia
{
    public interface IRepositorioRegistrarOfertaServicios
    {
        Migrante addConsultaHistorial(DateTime FechaSolicitud,
         DateTime FechaAceptacionRechazo,
         string DescripcionServicio,
          string EntidadQueLoOfrece,
           TipoEstado Estado);
    }
}