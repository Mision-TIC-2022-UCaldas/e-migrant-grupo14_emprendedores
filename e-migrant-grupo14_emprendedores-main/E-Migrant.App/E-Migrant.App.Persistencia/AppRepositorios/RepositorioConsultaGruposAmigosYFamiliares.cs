using System;
using E_Migrant.App.Dominio;
namespace E_Migrant.App.Persistencia
{
    public class RepositorioConsultaGruposAmigosYFamiliares : IRepositorioConsultaGruposAmigosYFamiliares
    {

        private readonly AppContext appContext;

        public RepositorioConsultaGruposAmigosYFamiliares(AppContext appContext)
        {
            this.appContext = appContext;
        }
        ConsultaGrupoAmigosFamiliares IRepositorioConsultaGruposAmigosYFamiliares.addConsultaGruposAmigosYFamiliares(
        string Nombre,
        string Apellidos,
        string Telefono,
        string DireccionElectronica)
        {

            try
            {
                if (Nombre == null || Apellidos == null || Telefono == null || DireccionElectronica == null)
                {
                    return null;
                }
                else
                {
                    var consultaGruposAmigosYFamiliares = new ConsultaGrupoAmigosFamiliares
                    {
                        nombre = Nombre,
                        apellidos = Apellidos,
                        telefono = Telefono,
                        direccionElectronica = DireccionElectronica
                    };
                    var datosmConsultaGruposAmigosYFamiliares = this.appContext.ConsultaGrupoAmigosFamiliares.Add(consultaGruposAmigosYFamiliares);
                    this.appContext.SaveChanges();
                    return datosmConsultaGruposAmigosYFamiliares.Entity;
                }

            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}