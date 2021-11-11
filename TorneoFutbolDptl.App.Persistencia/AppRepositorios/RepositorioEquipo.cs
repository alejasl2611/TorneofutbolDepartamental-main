using System.Collections.Generic;
using System.Linq;
using TorneoFutbolDptl.App.Dominio;

namespace TorneoFutbolDptl.App.Persistencia
{
    public class RepositorioEquipo : IRepositorioEquipo
    {
        private readonly AppContext _appContext = new AppContext();

        Equipo IRepositorioEquipo.AddEquipo(Equipo equipo)        
        {
            var EquipoAdicionado = _appContext.Equipos.Add(equipo);
            _appContext.SaveChanges();
            return EquipoAdicionado.Entity;

        }
       
        Equipo IRepositorioEquipo.GetEquipo(int idEquipo)
        {
            return _appContext.Equipos.Find(idEquipo);
        }

        void IRepositorioEquipo.DeleteEquipo(int idEquipo)
        {
            var equipoEncontrado = _appContext.Equipos.Find(idEquipo);
            if (equipoEncontrado == null)
                return;
            _appContext.Equipos.Remove(equipoEncontrado);
            _appContext.SaveChanges();
        } 
        
        IEnumerable<Equipo> IRepositorioEquipo.GetAllEquipos()
        {
            return _appContext.Equipos;
        }

        public Equipo UpdateEquipo(Equipo equipo)
        {
            var equipoEncontrado= _appContext.Equipos.FirstOrDefault(p => p.Id==equipo.Id);
            if (equipoEncontrado !=null)
            {
                equipoEncontrado.Nombre=equipo.Nombre;
                _appContext.SaveChanges();
            }
            return equipoEncontrado; 
        }           

        // Código ya implementado
        Municipio IRepositorioEquipo.AsignarMunicipioEquipo(int idEquipo, int idMunicipio)
        { var equipoEncontrado = _appContext.Equipos.FirstOrDefault(p => p.Id == idEquipo);
        if ( equipoEncontrado != null)
            { var municipioEncontrado = _appContext.Municipios.FirstOrDefault(m => m.Id == idMunicipio);
        if ( municipioEncontrado != null)
            { equipoEncontrado.Municipio = municipioEncontrado;
           _appContext.SaveChanges();
             }
          return municipioEncontrado;
          }
        return null;
        }

        // Código ya implementado
        DirectorTecnico IRepositorioEquipo.AsignarDirectorTecnico(int idEquipo, int idDirectorTecnico)
        { var equipoEncontrado = _appContext.Equipos.FirstOrDefault(p => p.Id == idEquipo);
        if ( equipoEncontrado != null)
            { var directorTecnicoEncontrado = _appContext.DirectorTecnicos.FirstOrDefault(m => m.Id == idDirectorTecnico);
        if ( directorTecnicoEncontrado != null)
            { equipoEncontrado.DirectorTecnico = directorTecnicoEncontrado;
           _appContext.SaveChanges();
             }
          return directorTecnicoEncontrado;
          }
        return null;
        }
    }
}