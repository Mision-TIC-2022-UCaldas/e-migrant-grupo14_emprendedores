using System;
using E_Migrant.App.Dominio;
namespace E_Migrant.App.Persistencia
{
    public class RepositorioRegistroOfertaServicio : IRepositorioRegistroOfertaServicio
    {

        private readonly AppContext _appContext;

        public RepositorioRegistroOfertaServicio(AppContext appContext)
        {
            _appContext = appContext;
        }
        RegistroOfertaServicios IRepositorioRegistroOfertaServicio.addRegistroOfertaServicio(
            string NombreServicio,
            int NumeroMaximoMigrantes,
            DateTime InicioOfertaServicio,
            DateTime FinOfertaServicio,
            TipoEstadoServicio EstadoServicio)
        {

            try
            {
                if (NombreServicio == null || NumeroMaximoMigrantes == null || InicioOfertaServicio == null || FinOfertaServicio == null || EstadoServicio == null)
                {
                    return null;
                }
                else
                {
                    var registroOfertaServicios = new RegistroOfertaServicios
                    {
                        nombreServicio = NombreServicio,
                        numeroMaximoMigrantes = NumeroMaximoMigrantes,
                        inicioOfertaServicio = InicioOfertaServicio,
                        finOfertaServicio = FinOfertaServicio,
                        estadoServicio = EstadoServicio
                    };
                    var datosRegistroOfertaServicios = _appContext.RegistroOfertaServicios.Add(registroOfertaServicios);
                    _appContext.SaveChanges();
                    return datosRegistroOfertaServicios.Entity;
                }

            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}