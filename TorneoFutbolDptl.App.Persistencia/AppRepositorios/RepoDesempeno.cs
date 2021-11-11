using System.Collections.Generic;
using System.Linq;
using TorneoFutbolDptl.App.Dominio;

namespace TorneoFutbolDptl.App.Persistencia
{
    public class RepositorioDesempenoEquipo : IRepositorioDesempenoEquipo
    {
        private readonly AppContext _appContext = new AppContext();

        DesempenoEquipo IRepositorioDesempenoEquipo.AddDesempenoEquipo(DesempenoEquipo desempenoEquipo)        
        {
            var DesempenoEquipoAdicionado = _appContext.DesempenoEquipos.Add(desempenoEquipo);
            _appContext.SaveChanges();
            return DesempenoEquipoAdicionado.Entity;

        }
       
        DesempenoEquipo IRepositorioDesempenoEquipo.GetDesempenoEquipo(int idDesempenoEquipo)
        {
            return _appContext.DesempenoEquipos.Find(idDesempenoEquipo);
        }

        void IRepositorioDesempenoEquipo.DeleteDesempenoEquipo(int idDesempenoEquipo)
        {
            var desempenoEquipoEncontrada = _appContext.DesempenoEquipos.Find(idDesempenoEquipo);
            if (desempenoEquipoEncontrada == null)
                return;
            _appContext.DesempenoEquipos.Remove(desempenoEquipoEncontrada);
            _appContext.SaveChanges();
        } 
        
        IEnumerable<DesempenoEquipo> IRepositorioDesempenoEquipo.GetAllDesempenoEquipo()
        {
            return _appContext.DesempenoEquipos;
        }

        public DesempenoEquipo UpdateDesempenoEquipo(DesempenoEquipo desempenoEquipo)
        {
            var desempenoEquipoEncontrada= _appContext.DesempenoEquipos.FirstOrDefault(p => p.Id==desempenoEquipo.Id);
            if (desempenoEquipoEncontrada !=null)
            {
                desempenoEquipoEncontrada.Id=desempenoEquipo.Id;
                _appContext.SaveChanges();
            }
            return desempenoEquipoEncontrada; 
        }         

        // Código ya implementado
        Equipo IRepositorioDesempenoEquipo.AsignarEquipo(int idDesempenoEquipo, int idEquipo)
        { var desempenoEquipoesEncontrado = _appContext.DesempenoEquipos.FirstOrDefault(p => p.Id == idDesempenoEquipo);
        if ( desempenoEquipoesEncontrado != null)
            { var equipoEncontrado = _appContext.Equipos.FirstOrDefault(m => m.Id == idEquipo);
        if ( equipoEncontrado != null)
            { desempenoEquipoesEncontrado.Equipo = equipoEncontrado;
           _appContext.SaveChanges();
             }
          return equipoEncontrado;
          }
        return null;
        }
    }
}