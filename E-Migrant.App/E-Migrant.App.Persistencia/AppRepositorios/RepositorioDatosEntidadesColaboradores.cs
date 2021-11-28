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
        public Boolean  GetDatosEntidadNit(string nit){
            var EntidadEncontrada = _appContext.DatosEntidadesColaboradoras.FirstOrDefault(E => E.nit==nit);
            if(EntidadEncontrada==null){
                return false;
            }{
                return true;
            }
        }
        public DatosEntidadesColaboradoras  GetDatosDeLaEntidad(string nit){

            return _appContext.DatosEntidadesColaboradoras.FirstOrDefault(E => E.nit==nit);
        }
        public DatosEntidadesColaboradoras  GetDatosDeLaEntidadId(int id){

            return _appContext.DatosEntidadesColaboradoras.FirstOrDefault(E => E.id==id);
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

        public DatosEntidadesColaboradoras updateDatosEntidad(DatosEntidadesColaboradoras datosEntidadesColaboradoras){
            var DatosEntidadEncontrada= _appContext.DatosEntidadesColaboradoras.FirstOrDefault(E => E.id== datosEntidadesColaboradoras.id);
            if(DatosEntidadEncontrada != null){
                DatosEntidadEncontrada.razonSocial = datosEntidadesColaboradoras.razonSocial;
                DatosEntidadEncontrada.direccion = datosEntidadesColaboradoras.direccion;
                DatosEntidadEncontrada.ciudad = datosEntidadesColaboradoras.ciudad;
                DatosEntidadEncontrada.Telefono = datosEntidadesColaboradoras.Telefono;
                DatosEntidadEncontrada.correoElectronico= datosEntidadesColaboradoras.correoElectronico;
                DatosEntidadEncontrada.sector = datosEntidadesColaboradoras.sector;
                DatosEntidadEncontrada.serviciosOfrece =datosEntidadesColaboradoras.serviciosOfrece;
                DatosEntidadEncontrada.paginaWeb= datosEntidadesColaboradoras.paginaWeb; 
                _appContext.SaveChanges();
            }
            return DatosEntidadEncontrada;
        }
    }
}