using System.Collections.Generic;
using TorneoFutbolDptl.App.Dominio;

namespace TorneoFutbolDptl.App.Persistencia
{
    public interface IRepositorioDirectorTecnico
    {
        DirectorTecnico AddDirectorTecnico(DirectorTecnico directorTecnico);
        DirectorTecnico GetDirectorTecnico(int idDirectorTecnico);
        void DeleteDirectorTecnico(int idDirectorTecnico);
        IEnumerable<DirectorTecnico> GetAllDirectorTecnicos();                  
        public DirectorTecnico UpdateDirectorTecnico(DirectorTecnico directorTecnico);
    }
}