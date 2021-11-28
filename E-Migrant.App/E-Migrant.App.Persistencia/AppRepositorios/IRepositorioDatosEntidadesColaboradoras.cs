using System;
using System.Collections.Generic;
using E_Migrant.App.Dominio;
namespace E_Migrant.App.Persistencia
{
    public interface IRepositorioDatosEntidadesColaboradoras
    {
         DatosEntidadesColaboradoras AddDatosEntidades(DatosEntidadesColaboradoras datosEntidadesColaboradoras);
         //DatosEntidadesColaboradoras MisDatosEntidades(string CorreoElectronico);

         //DatosEntidadesColaboradoras GetDatosMigranteCoreo(string correo);

         //Migrante updateDatosmIgracion(Migrante migrante );
    }
}