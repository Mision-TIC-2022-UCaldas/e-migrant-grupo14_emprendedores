using System;
using E_Migrant.App.Dominio;
namespace E_Migrant.App.Persistencia
{
    public class RepositorioConsultaServicios : IRepositorioConsultaServicios
    {

        private readonly AppContext appContext;

        public RepositorioConsultaServicios(AppContext appContext)
        {
            this.appContext = appContext;
        }
        ConsultaServicios IRepositorioConsultaServicios.addConsultaServicios(
            int Total,
            DateTime FechaInicioServicio,
            TipoEstadoServicio EstadoServicio)
        {

            try
            {
                if (Total == null || FechaInicioServicio == null || EstadoServicio == null)
                {
                    return null;
                }
                else
                {
                    var consultaServicios = new ConsultaServicios
                    {
                        Total = Total,
                        FechaInicioServicio = FechaInicioServicio,
                        EstadoServicio = EstadoServicio
                    };
                    var datosconsultaServicios = this.appContext.Migrante.Add(consultaServicios);
                    this.appContext.SaveChanges();
                    return datosconsultaServicios.Entity;
                }

            }
            catch (System.Exception)
            {
                throw;
            }


        }

    }
}