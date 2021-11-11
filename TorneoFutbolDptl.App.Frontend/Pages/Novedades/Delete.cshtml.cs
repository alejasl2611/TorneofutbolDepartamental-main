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
    public class DeleteModel : PageModel
    {
        private readonly IRepositorioNovedad _repoNovedad;
        public Novedad novedad {get; set;}
        public DeleteModel(IRepositorioNovedad repoNovedad)
        {
            _repoNovedad = repoNovedad;
        }

        public IActionResult OnGet(int id)
        {
            novedad = _repoNovedad.GetNovedad(id);
            if(novedad == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost(Novedad novedad)
        {
            _repoNovedad.DeleteNovedad(novedad.Id);
            return RedirectToPage("Index");
        }
    }
}