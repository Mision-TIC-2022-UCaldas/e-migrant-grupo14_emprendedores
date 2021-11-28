using System;
using System.Collections.Generic;
using E_Migrant.App.Dominio;
namespace E_Migrant.App.Persistencia
{
    public interface IRepositorioDatosEntidadesColaboradoras
    {
         DatosEntidadesColaboradoras AddDatosEntidades(DatosEntidadesColaboradoras datosEntidadesColaboradoras);
         //DatosEntidadesColaboradoras MisDatosEntidades(string CorreoElectronico);

         Boolean GetDatosEntidadNit(string nit);

         IEnumerable<DatosEntidadesColaboradoras> GetAllEntidades();
         IEnumerable<DatosEntidadesColaboradoras> GetDatosEntidadNitFiltro(string filtro);
         DatosEntidadesColaboradoras  GetDatosDeLaEntidad(string nit);
         DatosEntidadesColaboradoras updateDatosEntidad(DatosEntidadesColaboradoras datosEntidadesColaboradoras);
    }
}