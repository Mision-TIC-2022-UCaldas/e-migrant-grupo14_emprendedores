using System;
using System.Collections.Generic;
using E_Migrant.App.Dominio;

namespace E_Migrant.App.Persistencia
{
    public interface IRepositorioDatosMigrante
    {
         Migrante AddDatosMigrante(string Nombre, string Apellidos, int TipoIdentificacion, string NumeroIdentificacion, string Pais, DateTime FechaNacimiento, string CorreoElectronico,
         string NumeroTelefonico, string DireccionActual, string Ciudad, string situacionLaboral);
         Migrante Misdatos(string CorreoElectronico);

         Migrante GetDatosMigranteCoreo(string correo);

         Migrante updateDatosmIgracion(Migrante migrante );
         Migrante updateEmailMigrante(string email);
         IEnumerable<Migrante> GetAllMigrantes();
         IEnumerable<Migrante> GetDatosMigrantesFiltro(string filtro);
         Migrante GetMigranteid(int id);
    }
}