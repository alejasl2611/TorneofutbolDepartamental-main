using System.Collections.Generic;
using System.Linq;
using TorneoFutbolDptl.App.Dominio;

namespace TorneoFutbolDptl.App.Persistencia
{
    public class RepositorioDirectorTecnico : IRepositorioDirectorTecnico
    {
        private readonly AppContext _appContext = new AppContext();

        DirectorTecnico IRepositorioDirectorTecnico.AddDirectorTecnico(DirectorTecnico directorTecnico)        
        {
            var DirectorTecnicoAdicionado = _appContext.DirectorTecnicos.Add(directorTecnico);
            _appContext.SaveChanges();
            return DirectorTecnicoAdicionado.Entity;

        }
       
        DirectorTecnico IRepositorioDirectorTecnico.GetDirectorTecnico(int idDirectorTecnico)
        {
            return _appContext.DirectorTecnicos.Find(idDirectorTecnico);
        }

        void IRepositorioDirectorTecnico.DeleteDirectorTecnico(int idDirectorTecnico)
        {
            var directorTecnicoEncontrado = _appContext.DirectorTecnicos.Find(idDirectorTecnico);
            if (directorTecnicoEncontrado == null)
                return;
            _appContext.DirectorTecnicos.Remove(directorTecnicoEncontrado);
            _appContext.SaveChanges();
        } 
        
        IEnumerable<DirectorTecnico> IRepositorioDirectorTecnico.GetAllDirectorTecnicos()
        {
            return _appContext.DirectorTecnicos;
        }

        public DirectorTecnico UpdateDirectorTecnico(DirectorTecnico directorTecnico)
        {
            var directorTecnicoEncontrado= _appContext.DirectorTecnicos.FirstOrDefault(p => p.Id==directorTecnico.Id);
            if (directorTecnicoEncontrado !=null)
            {
                directorTecnicoEncontrado.Nombre=directorTecnico.Nombre;
                _appContext.SaveChanges();
            }
            return directorTecnicoEncontrado; 
        }  
    }
}