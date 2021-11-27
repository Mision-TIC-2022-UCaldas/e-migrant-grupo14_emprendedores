using System;
using E_Migrant.App.Dominio;
namespace E_Migrant.App.Persistencia
{
    public class RepositorioRegistrarEntidad : IRepositorioRegistrarEntidad
    {

        private readonly AppContext appContext;

        public RepositorioRegistrarEntidad(AppContext appContext)
        {
            this.appContext = appContext;
        }
        RegistroEntidad IRepositorioRegistrarEntidad.addRegistrarEntidad(
        string RazonSocial,
         string Nit,
          string Direccion,
           string Ciudad,
            string Telefono,
             string DireccionElectronica,
              string PaginaWeb,
               TipoSector Sector,
                TipoServicioOfrecido ServicioQueOfrece)
        {

            try
            {
                if (RazonSocial == null || Nit == null || Direccion == null || Ciudad == null || Telefono == null || Sector == null || ServicioQueOfrece == null)
                {
                    return null;
                }
                else
                {
                    var registroEntidad = new RegistroEntidad
                    {
                        razonSocial = RazonSocial,
                        nit = Nit,
                        direccion = Direccion,
                        ciudad = Ciudad,
                        direccionElectronica = DireccionElectronica,
                        paginaWeb = PaginaWeb,
                        telefono = Telefono,
                        sector = Sector,
                        servicioQueOfrece = ServicioQueOfrece
                    };
                    var datosRegistroEntidad = this.appContext.Migrante.Add(registroEntidad);
                    this.appContext.SaveChanges();
                    return datosRegistroEntidad.Entity;
                }

            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}