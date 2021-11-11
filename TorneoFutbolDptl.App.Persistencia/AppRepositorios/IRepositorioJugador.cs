using System.Collections.Generic;
using TorneoFutbolDptl.App.Dominio;

namespace TorneoFutbolDptl.App.Persistencia
{
    public interface IRepositorioJugador
    {
        Jugador AddJugador(Jugador jugador);
        Jugador GetJugador(int idJugador);
        void DeleteJugador(int idJugador);
        IEnumerable<Jugador> GetAllJugadores(); 
        Jugador UpdateJugador(Jugador jugador);
        Equipo AsignarEquipoJugador(int idJugador, int idEquipo);
        Posicion AsignarPosicionJugador(int idJugador, int idPosicion);
    }
}