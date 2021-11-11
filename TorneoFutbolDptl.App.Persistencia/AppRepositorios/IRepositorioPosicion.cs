using System.Collections.Generic;
using TorneoFutbolDptl.App.Dominio;

namespace TorneoFutbolDptl.App.Persistencia
{
    public interface IRepositorioPosicion
    {
        Posicion AddPosicion(Posicion posicion);
        Posicion GetPosicion(int idPosicion);
        void DeletePosicion(int idPosicion);
        IEnumerable<Posicion> GetAllPosiciones();
        public Posicion UpdatePosicion(Posicion posicion);                           
    }
}