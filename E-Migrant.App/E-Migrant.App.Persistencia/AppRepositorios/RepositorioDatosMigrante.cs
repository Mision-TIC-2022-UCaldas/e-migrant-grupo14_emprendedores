using System;
using E_Migrant.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using E_Migrant.App.Persistencia;
namespace E_Migrant.App.Persistencia
{
    public class RepositorioDatosMigrante : IRepositorioDatosMigrante
    {

        private readonly AppContext _appContext;
        

        public RepositorioDatosMigrante(AppContext appContext)
        {
            _appContext = appContext;
        }
        Migrante IRepositorioDatosMigrante.AddDatosMigrante(string Nombre, string Apellidos, int TipoIdentificacion, string NumeroIdentificacion, string Pais, DateTime FechaNacimiento, string CorreoElectronico,
         string NumeroTelefonico, string DireccionActual, string Ciudad, string situacionLaboral)
        {

            try
            {
                if (Nombre == null || Apellidos==null || NumeroIdentificacion == null || Pais == null )
                {
                    return null;
                }
                else
                {
                    var DatosmIgrante = new Migrante
                    {
                        nombre = Nombre,
                        apellidos = Apellidos,
                        tipoIdentificacion = TipoIdentificacion,
                        numeroIdentificacion = NumeroIdentificacion,
                        pais = Pais,
                        fechaNacimiento = FechaNacimiento,
                        correoElectronico = CorreoElectronico,
                        numeroTelefonico =NumeroTelefonico,
                        direccionActual = DireccionActual,
                        ciudad = Ciudad,
                        situacionLaboral =situacionLaboral
                    };
                    var DatosmIgranteAlmacenados= _appContext.Migrante.Add(DatosmIgrante);
                    _appContext.SaveChanges();
                    return DatosmIgranteAlmacenados.Entity;
                }

            }
            catch(System.Exception)
            {
                throw;
            }

            
        }
        Migrante IRepositorioDatosMigrante.Misdatos(string CorreoElectronico){
        var DatosmIgrante = new Migrante{correoElectronico = CorreoElectronico};
        var DatosmIgranteAlmacenados= _appContext.Migrante.Add(DatosmIgrante);
        _appContext.SaveChanges();
        return DatosmIgranteAlmacenados.Entity;
        }
        Migrante IRepositorioDatosMigrante.GetDatosMigranteCoreo(string CorreoElectronico){
            return _appContext.Migrante.FirstOrDefault(M => M.correoElectronico==CorreoElectronico);
        }

    }
}