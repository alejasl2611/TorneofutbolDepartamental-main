using System.Collections.Generic;
using System.Linq;
using TorneoFutbolDptl.App.Dominio;

namespace TorneoFutbolDptl.App.Persistencia
{
    public class RepositorioNovedad : IRepositorioNovedad
    {
        private readonly AppContext _appContext = new AppContext();

        Novedad IRepositorioNovedad.AddNovedad(Novedad novedad)        
        {
            var NovedadAdicionado = _appContext.Novedades.Add(novedad);
            _appContext.SaveChanges();
            return NovedadAdicionado.Entity;

        }
       
        Novedad IRepositorioNovedad.GetNovedad(int idNovedad)
        {
            return _appContext.Novedades.Find(idNovedad);
        }

        void IRepositorioNovedad.DeleteNovedad(int idNovedad)
        {
            var novedadEncontrada = _appContext.Novedades.Find(idNovedad);
            if (novedadEncontrada == null)
                return;
            _appContext.Novedades.Remove(novedadEncontrada);
            _appContext.SaveChanges();
        } 
        
        IEnumerable<Novedad> IRepositorioNovedad.GetAllNovedades()
        {
            return _appContext.Novedades;
        }

        public Novedad UpdateNovedad(Novedad novedad)
        {
            var novedadEncontrada= _appContext.Novedades.FirstOrDefault(p => p.Id==novedad.Id);
            if (novedadEncontrada !=null)
            {
                novedadEncontrada.Id=novedad.Id;
                _appContext.SaveChanges();
            }
            return novedadEncontrada; 
        }         

        // Código ya implementado
        Jugador IRepositorioNovedad.AsignarJugador(int idNovedad, int idJugador)
        { var novedadesEncontrado = _appContext.Novedades.FirstOrDefault(p => p.Id == idNovedad);
        if ( novedadesEncontrado != null)
            { var jugadorEncontrado = _appContext.Jugadores.FirstOrDefault(m => m.Id == idJugador);
        if ( jugadorEncontrado != null)
            { novedadesEncontrado.Jugador = jugadorEncontrado;
           _appContext.SaveChanges();
             }
          return jugadorEncontrado;
          }
        return null;
        }
    }
}