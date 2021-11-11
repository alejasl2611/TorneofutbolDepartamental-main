using System;
using System.ComponentModel.DataAnnotations;
namespace TorneoFutbolDptl.App.Dominio
{
    public class Jugador
    {
        // Identificador único de cada Jugador
        public int Id { get; set; }


        [Display(Name = "Equipo local")]
        public string Nombre {get;set;}
        [Display(Name = "Número del jugador")]
        public string Numero {get;set;}
        // Relacion entre el Jugador y equipo FK
        public Equipo Equipo { get; set; }
        // Relacion entre el Jugador y la posion FK        
        [Display(Name = "Posición")]
        public Posicion Posicion { get; set; }
        //jdjjd
    }
}
