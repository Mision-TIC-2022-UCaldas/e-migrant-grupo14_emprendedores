using System;
using E_Migrant.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using E_Migrant.App.Persistencia;
namespace E_Migrant.App.Persistencia
{
    public class RepositorioDatosEntidadesColaboradores : IRepositorioDatosEntidadesColaboradoras
    {
        private readonly AppContext _appContext;
        

        public RepositorioDatosEntidadesColaboradores(AppContext appContext)
        {
            _appContext = appContext;
        }
        DatosEntidadesColaboradoras IRepositorioDatosEntidadesColaboradoras.AddDatosEntidades(DatosEntidadesColaboradoras datosEntidadesColaboradoras){
            var EntidadDatosAlmacenados= _appContext.DatosEntidadesColaboradoras.Add(datosEntidadesColaboradoras);
            _appContext.SaveChanges();
            return EntidadDatosAlmacenados.Entity;
        }
    }
}