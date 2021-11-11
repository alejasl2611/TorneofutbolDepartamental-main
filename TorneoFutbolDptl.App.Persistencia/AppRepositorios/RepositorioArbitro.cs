using System.Collections.Generic;
using System.Linq;
using TorneoFutbolDptl.App.Dominio;

namespace TorneoFutbolDptl.App.Persistencia
{
    public class RepositorioArbitro : IRepositorioArbitro
    {
        private readonly AppContext _appContext = new AppContext();

        Arbitro IRepositorioArbitro.AddArbitro(Arbitro arbitro)        
        {
            var ArbitroAdicionado = _appContext.Arbitros.Add(arbitro);
            _appContext.SaveChanges();
            return ArbitroAdicionado.Entity;

        }
       
        Arbitro IRepositorioArbitro.GetArbitro(int idArbitro)
        {
            return _appContext.Arbitros.Find(idArbitro);
        }

        void IRepositorioArbitro.DeleteArbitro(int idArbitro)
        {
            var arbitroEncontrado = _appContext.Arbitros.Find(idArbitro);
            if (arbitroEncontrado == null)
                return;
            _appContext.Arbitros.Remove(arbitroEncontrado);
            _appContext.SaveChanges();
        } 
        
        IEnumerable<Arbitro> IRepositorioArbitro.GetAllArbitros()
        {
            return _appContext.Arbitros;
        }

        public Arbitro UpdateArbitro(Arbitro arbitro)
        {
            var arbitroEncontrado= _appContext.Arbitros.FirstOrDefault(p => p.Id==arbitro.Id);
            if (arbitroEncontrado !=null)
            {
                arbitroEncontrado.Nombre=arbitro.Nombre;
                _appContext.SaveChanges();
            }
            return arbitroEncontrado; 
        }  
    }
}   