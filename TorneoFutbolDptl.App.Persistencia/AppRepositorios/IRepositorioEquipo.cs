using System.Collections.Generic;

using TorneoFutbolDptl.App.Dominio;

namespace TorneoFutbolDptl.App.Persistencia
{
    public interface IRepositorioEquipo
    {
        Equipo AddEquipo(Equipo equipo);
        Equipo GetEquipo(int idEquipo);
        void DeleteEquipo(int idEquipo);
        IEnumerable<Equipo> GetAllEquipos(); 
        Equipo UpdateEquipo(Equipo equipo);
        Municipio  AsignarMunicipioEquipo(int idEquipo, int idMunicipio);
        DirectorTecnico  AsignarDirectorTecnico(int idEquipo, int idDirectorTecnico); 
    }
}