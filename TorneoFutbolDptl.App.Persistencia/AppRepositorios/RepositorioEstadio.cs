using System.Collections.Generic;
using System.Linq;
using TorneoFutbolDptl.App.Dominio;

namespace TorneoFutbolDptl.App.Persistencia
{
    public class RepositorioEstadio : IRepositorioEstadio
    {
        private readonly AppContext _appContext = new AppContext();

        Estadio IRepositorioEstadio.AddEstadio(Estadio estadio)        
        {
            var EstadioAdicionado = _appContext.Estadios.Add(estadio);
            _appContext.SaveChanges();
            return EstadioAdicionado.Entity;

        }
       
        Estadio IRepositorioEstadio.GetEstadio(int idEstadio)
        {
            return _appContext.Estadios.Find(idEstadio);
        }

        void IRepositorioEstadio.DeleteEstadio(int idEstadio)
        {
            var estadioEncontrado = _appContext.Estadios.Find(idEstadio);
            if (estadioEncontrado == null)
                return;
            _appContext.Estadios.Remove(estadioEncontrado);
            _appContext.SaveChanges();
        } 
        
        IEnumerable<Estadio> IRepositorioEstadio.GetAllEstadios()
        {
            return _appContext.Estadios;
        }

        public Estadio UpdateEstadio(Estadio estadio)
        {
            var estadioEncontrado= _appContext.Estadios.FirstOrDefault(p => p.Id==estadio.Id);
            if (estadioEncontrado !=null)
            {
                estadioEncontrado.Nombre=estadio.Nombre;
                _appContext.SaveChanges();
            }
            return estadioEncontrado; 
        }           

        // Código ya implementado
        Municipio IRepositorioEstadio.AsignarMunicipio(int idEstadio, int idMunicipio)
        { var estadioEncontrado = _appContext.Estadios.FirstOrDefault(p => p.Id == idEstadio);
        if ( estadioEncontrado != null)
            { var municipioEncontrado = _appContext.Municipios.FirstOrDefault(m => m.Id == idMunicipio);
        if ( municipioEncontrado != null)
            { estadioEncontrado.Municipio = municipioEncontrado;
           _appContext.SaveChanges();
             }
          return municipioEncontrado;
          }
        return null;
        }
    }
}