using System;
using System.Collections.Generic;
using E_Migrant.App.Dominio;
namespace E_Migrant.App.Persistencia
{
    public interface IRepositorioConsultaHistorial
    {
        ConsultaHistorial addConsultaHistorial(DateTime FechaSolicitud,
         DateTime FechaAceptacionRechazo,
         string DescripcionServicio,
          string EntidadQueLoOfrece,
           TipoEstado Estado);
    }
}