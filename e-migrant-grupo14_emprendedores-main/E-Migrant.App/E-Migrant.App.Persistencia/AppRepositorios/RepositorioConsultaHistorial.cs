using System;
using E_Migrant.App.Dominio;
namespace E_Migrant.App.Persistencia
{
    public class RepositorioConsultaHistorial : IRepositorioConsultaHistorial
    {

        private readonly AppContext appContext;

        public RepositorioConsultaHistorial(AppContext appContext)
        {
            this.appContext = appContext;
        }
        ConsultaHistorial IRepositorioConsultaHistorial.addConsultaHistorial(
        DateTime FechaSolicitud,
        DateTime FechaAceptacionRechazo,
        string DescripcionServicio,
        string EntidadQueLoOfrece,
        TipoEstado Estado)
        {

            try
            {
                if (FechaSolicitud == null || FechaAceptacionRechazo == null || DescripcionServicio == null || EntidadQueLoOfrece == null || Estado == null)
                {
                    return null;
                }
                else
                {
                    var consultaHistorial = new ConsultaHistorial
                    {
                        fechaSolicitud = FechaSolicitud,
                        fechaAceptacionRechazo = FechaAceptacionRechazo,
                        descripcionServicio = DescripcionServicio,
                        entidadQueLoOfrece = EntidadQueLoOfrece,
                        estado = Estado
                    };
                    var datosConsultaHistorialAlmacenadas = this.appContext.Migrante.Add(consultaHistorial);
                    this.appContext.SaveChanges();
                    return datosConsultaHistorialAlmacenadas.Entity;
                }

            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}