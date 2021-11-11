using System.Collections.Generic;
using System.Linq;
using TorneoFutbolDptl.App.Dominio;

namespace TorneoFutbolDptl.App.Persistencia
{
    public class RepositorioPartido : IRepositorioPartido
    {
        private readonly AppContext _appContext = new AppContext();

        Partido IRepositorioPartido.AddPartido(Partido partido)        
        {
            var PartidoAdicionado = _appContext.Partidos.Add(partido);
            _appContext.SaveChanges();
            return PartidoAdicionado.Entity;

        }
       
        Partido IRepositorioPartido.GetPartido(int idPartido)
        {
            return _appContext.Partidos.Find(idPartido);
        }

        void IRepositorioPartido.DeletePartido(int idPartido)
        {
            var partidoEncontrado = _appContext.Partidos.Find(idPartido);
            if (partidoEncontrado == null)
                return;
            _appContext.Partidos.Remove(partidoEncontrado);
            _appContext.SaveChanges();
        } 
        
        IEnumerable<Partido> IRepositorioPartido.GetAllPartidos()
        {
            return _appContext.Partidos;
        }

        public Partido UpdatePartido(Partido partido)
        {
            var partidoEncontrado= _appContext.Partidos.FirstOrDefault(p => p.Id==partido.Id);
            if (partidoEncontrado !=null)
            {
                partidoEncontrado.Id=partido.Id;
                partidoEncontrado.EquipoLocal=partido.EquipoLocal;
                partidoEncontrado.EquipoVisita=partido.EquipoVisita;
                partidoEncontrado.EquipoLocalMarca=partido.EquipoLocalMarca;
                partidoEncontrado.EquipoVisitaMarca=partido.EquipoVisitaMarca;
                partidoEncontrado.FechaHora=partido.FechaHora;
                partidoEncontrado.Arbitro=partido.Arbitro;
                partidoEncontrado.Estadio=partido.Estadio;
                partidoEncontrado.Novedad=partido.Novedad;


                _appContext.SaveChanges();
            }
            return partidoEncontrado; 
        }           

        // Código ya implementado
        Arbitro IRepositorioPartido.AsignarArbitroPartido(int idPartido, int idArbitro)
        { var partidoEncontrado = _appContext.Partidos.FirstOrDefault(p => p.Id == idPartido);
        if ( partidoEncontrado != null)
            { var arbitroEncontrado = _appContext.Arbitros.FirstOrDefault(m => m.Id == idArbitro);
        if ( arbitroEncontrado != null)
            { partidoEncontrado.Arbitro = arbitroEncontrado;
           _appContext.SaveChanges();
             }
          return arbitroEncontrado;
          }
        return null;
        }


        // Código ya implementado
       Estadio IRepositorioPartido.AsignarEstadioPartido(int idPartido, int idEstadio)
        { var partidoEncontrado = _appContext.Partidos.FirstOrDefault(p => p.Id == idPartido);
        if ( partidoEncontrado != null)
            { var estadioEncontrado = _appContext.Estadios.FirstOrDefault(m => m.Id == idEstadio);
        if ( estadioEncontrado != null)
            { partidoEncontrado.Estadio = estadioEncontrado;
           _appContext.SaveChanges();
             }
          return estadioEncontrado;
          }
        return null;
        }

       // Código ya implementado
        Novedad IRepositorioPartido.AsignarNovedadPartido(int idPartido, int idNovedad)
        { var partidoEncontrado = _appContext.Partidos.FirstOrDefault(p => p.Id == idPartido);
        if ( partidoEncontrado != null)
            { var novedadEncontrado = _appContext.Novedades.FirstOrDefault(m => m.Id == idNovedad);
        if ( novedadEncontrado != null)
            { partidoEncontrado.Novedad = novedadEncontrado;
           _appContext.SaveChanges();
             }
          return novedadEncontrado;
          }
        return null;
        }
    }
}