using System.Collections.Generic;
using TorneoFutbolDptl.App.Dominio;

namespace TorneoFutbolDptl.App.Persistencia
{
    public interface IRepositorioNovedad
    {
        Novedad AddNovedad(Novedad novedad);
        Novedad GetNovedad(int idNovedad);
        void DeleteNovedad(int idNovedad);
        IEnumerable<Novedad> GetAllNovedades(); 
        Novedad UpdateNovedad(Novedad novedad);
        Jugador  AsignarJugador(int idNovedad, int idJugador); 
    }
}