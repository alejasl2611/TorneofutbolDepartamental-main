using System.Collections.Generic;
using System.Linq;
using TorneoFutbolDptl.App.Dominio;

namespace TorneoFutbolDptl.App.Persistencia
{
    public class RepositorioPosicion : IRepositorioPosicion
    {
        private readonly AppContext _appContext = new AppContext();

        Posicion IRepositorioPosicion.AddPosicion(Posicion posicion)        
        {
            var PosicionAdicionado = _appContext.Posiciones.Add(posicion);
            _appContext.SaveChanges();
            return PosicionAdicionado.Entity;

        }
       
        Posicion IRepositorioPosicion.GetPosicion(int idPosicion)
        {
            return _appContext.Posiciones.Find(idPosicion);
        }

        void IRepositorioPosicion.DeletePosicion(int idPosicion)
        {
            var posicionEncontrado = _appContext.Posiciones.Find(idPosicion);
            if (posicionEncontrado == null)
                return;
            _appContext.Posiciones.Remove(posicionEncontrado);
            _appContext.SaveChanges();
        } 
        
        IEnumerable<Posicion> IRepositorioPosicion.GetAllPosiciones()
        {
            return _appContext.Posiciones;
        }

        public Posicion UpdatePosicion(Posicion posicion)
        {
            var posicionEncontrado= _appContext.Posiciones.FirstOrDefault(p => p.Id==posicion.Id);
            if (posicionEncontrado !=null)
            {
                posicionEncontrado.Nombre=posicion.Nombre;
                _appContext.SaveChanges();
            }
            return posicionEncontrado; 
        }         
    }
}