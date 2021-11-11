using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolDptl.App.Dominio;
using TorneoFutbolDptl.App.Persistencia;

namespace TorneoFutbolDptl.App.Frontend.Pages.Novedades
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioNovedad _repoNovedad;
        public IEnumerable<Novedad> novedades {get; set;}

        public IndexModel(IRepositorioNovedad repoNovedad)
        {
            _repoNovedad = repoNovedad;
        }

        public void OnGet()
        {
            novedades = _repoNovedad.GetAllNovedades();
        }
    }
}