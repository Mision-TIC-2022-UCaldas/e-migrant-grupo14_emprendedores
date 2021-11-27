using System;
using System.Collections.Generic;
using E_Migrant.App.Dominio;
namespace E_Migrant.App.Persistencia
{
    public interface IRepositorioConsultaGruposAmigosYFamiliares
    {
        ConsultaGrupoAmigosFamiliares addConsultaGruposAmigosYFamiliares(string Nombre,
         string Apellidos,
         string Telefono,
         string DireccionElectronica);
    }
}