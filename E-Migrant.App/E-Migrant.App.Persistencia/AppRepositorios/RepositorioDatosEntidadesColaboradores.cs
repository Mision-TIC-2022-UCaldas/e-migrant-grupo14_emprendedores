using System;
using E_Migrant.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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
        Boolean IRepositorioDatosEntidadesColaboradoras.GetDatosEntidadNit(string nit){
            var EntidadEncontrada = _appContext.DatosEntidadesColaboradoras.FirstOrDefault(E => E.nit==nit);
            if(EntidadEncontrada==null){
                return false;
            }{
                return true;
            }
        }
        public IEnumerable<DatosEntidadesColaboradoras> GetAllEntidades(){
            return _appContext.DatosEntidadesColaboradoras;
        }
        public IEnumerable<DatosEntidadesColaboradoras> GetDatosEntidadNitFiltro(string filtro=null){
            
            var Entidades = GetAllEntidades();
            if(Entidades!=null){
                if(!String.IsNullOrEmpty(filtro)){
                    Entidades = Entidades.Where(E => E.nit.Contains(filtro));
                }
            }
            return Entidades;
        }

        
    }
}