using System;
using System.Collections.Generic;
using E_Migrant.App.Dominio;
namespace E_Migrant.App.Persistencia
{
    public interface IRepositorioDatosMigrante
    {
         Migrante AddDatosMigrante(string Nombre, string Apellidos, tipoIdentificacion TipoIdentificacion, string NumeroIdentificacion, string Pais, DateTime FechaNacimiento, string CorreoElectronico,
         string NumeroTelefonico, string DireccionActual, string Ciudad, string SituacionLaboral);
    }
}