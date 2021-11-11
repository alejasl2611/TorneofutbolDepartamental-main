using System.Collections.Generic;
using TorneoFutbolDptl.App.Dominio;

namespace TorneoFutbolDptl.App.Persistencia
{
    public interface IRepositorioMunicipio
    {
        Municipio AddMunicipio(Municipio municipio);
        Municipio GetMunicipio(int idMunicipio);
        void DeleteMunicipio(int idMunicipio);
        IEnumerable<Municipio> GetAllMunicipios();
        public Municipio UpdateMunicipio(Municipio municipio);
    }
}