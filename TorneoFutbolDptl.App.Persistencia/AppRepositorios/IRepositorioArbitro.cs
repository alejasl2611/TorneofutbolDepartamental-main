using System.Collections.Generic;
using TorneoFutbolDptl.App.Dominio;

namespace TorneoFutbolDptl.App.Persistencia
{
    public interface IRepositorioArbitro
    {
        Arbitro AddArbitro(Arbitro arbitro);
        Arbitro GetArbitro(int idArbitro);
        void DeleteArbitro(int idArbitro);
        IEnumerable<Arbitro> GetAllArbitros();                  
        public Arbitro UpdateArbitro(Arbitro arbitro);
    }
}