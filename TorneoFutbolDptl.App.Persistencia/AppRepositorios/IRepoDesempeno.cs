using System.Collections.Generic;
using TorneoFutbolDptl.App.Dominio;

namespace TorneoFutbolDptl.App.Persistencia
{
    public interface IRepositorioDesempenoEquipo
    {
        DesempenoEquipo AddDesempenoEquipo(DesempenoEquipo desempenoEquipo);
        DesempenoEquipo GetDesempenoEquipo(int idDesempenoEquipo);
        void DeleteDesempenoEquipo(int idDesempenoEquipo);
        IEnumerable<DesempenoEquipo> GetAllDesempenoEquipo(); 
        DesempenoEquipo UpdateDesempenoEquipo(DesempenoEquipo desempenoEquipo);
        Equipo  AsignarEquipo(int idDesempenoEquipo, int idEquipo); 
    }
}