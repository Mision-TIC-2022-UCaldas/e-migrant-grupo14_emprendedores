using System;
using System.Collections.Generic;
using E_Migrant.App.Dominio;
namespace E_Migrant.App.Persistencia
{
    public interface IRepositorioRegistrarEntidad
    {
        RegistroEntidad addRegistrarEntidad(
            string RazonSocial,
            string Nit,
            string Direccion,
            string Ciudad,
            string Telefono,
            string DireccionElectronica,
            string PaginaWeb,
            TipoSector Sector,
            TipoServicioOfrecido ServicioQueOfrece
        );
    }
}