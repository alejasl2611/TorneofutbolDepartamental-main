using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoFutbolDptl.App.Dominio;
using TorneoFutbolDptl.App.Persistencia;

namespace TorneoFutbolDptl.App.Frontend.Pages.Jugadores
{
    public class DeleteModel : PageModel
    {
        private readonly IRepositorioJugador _repoJugador;
        public Jugador jugador {get; set;}
        public DeleteModel(IRepositorioJugador repoJugador)
        {
            _repoJugador = repoJugador;
        }

        public IActionResult OnGet(int id)
        {
            jugador = _repoJugador.GetJugador(id);
            if(jugador == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost(Jugador jugador)
        {
            _repoJugador.DeleteJugador(jugador.Id);
            return RedirectToPage("Index");
        }
    }
}