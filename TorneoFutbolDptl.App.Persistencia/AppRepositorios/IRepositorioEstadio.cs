using System.Collections.Generic;
using TorneoFutbolDptl.App.Dominio;

namespace TorneoFutbolDptl.App.Persistencia
{
    public interface IRepositorioEstadio
    {
        Estadio AddEstadio(Estadio estadio);
        Estadio GetEstadio(int idEstadio);
        void DeleteEstadio(int idEstadio);
        IEnumerable<Estadio> GetAllEstadios(); 
        Estadio UpdateEstadio(Estadio estadio);
        Municipio  AsignarMunicipio(int idEstadio, int idMunicipio); 
    }
}