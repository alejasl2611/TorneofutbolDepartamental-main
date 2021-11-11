using System.Collections.Generic;
using System.Linq;
using TorneoFutbolDptl.App.Dominio;

namespace TorneoFutbolDptl.App.Persistencia
{
    public class RepositorioMunicipio : IRepositorioMunicipio
    {
        private readonly AppContext _appContext = new AppContext();

        Municipio IRepositorioMunicipio.AddMunicipio(Municipio municipio)        
        {
            var MunicipioAdicionado = _appContext.Municipios.Add(municipio);
            _appContext.SaveChanges();
            return MunicipioAdicionado.Entity;

        }
       
        Municipio IRepositorioMunicipio.GetMunicipio(int idMunicipio)
        {
            return _appContext.Municipios.Find(idMunicipio);
        }

        void IRepositorioMunicipio.DeleteMunicipio(int idMunicipio)
        {
            var municipioEncontrado = _appContext.Municipios.Find(idMunicipio);
            if (municipioEncontrado == null)
                return;
            _appContext.Municipios.Remove(municipioEncontrado);
            _appContext.SaveChanges();
        } 
        
        IEnumerable<Municipio> IRepositorioMunicipio.GetAllMunicipios()
        {
            return _appContext.Municipios;
        }

        public Municipio UpdateMunicipio(Municipio municipio)
        {
            var municipioEncontrado= _appContext.Municipios.FirstOrDefault(p => p.Id==municipio.Id);
            if (municipioEncontrado !=null)
            {
                municipioEncontrado.Nombre=municipio.Nombre;
                _appContext.SaveChanges();
            }
            return municipioEncontrado; 
        }                  
    }
}   
