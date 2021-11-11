using System;
using System.ComponentModel.DataAnnotations;

namespace TorneoFutbolDptl.App.Dominio
{
    public class Novedad
    {
        // Identificador único de cada Novedad
        public int Id { get; set; }
        [Display(Name = "Tarjeta amarilla")]
        public int TarjetaAmarilla {get;set;}
        [Display(Name = "Fecha y hora")]
        public DateTime FechaHoraTA  { get; set; }
        [Display(Name = "Tarjeta roja")]
        public int TarjetaRoja {get;set;}
        [Display(Name = "Fecha y hora")]

        public DateTime FechaHoraTR  { get; set; }
        [Display(Name = "Gol equipo local")]

        public int GolEquipoLocal {get;set;}
        [Display(Name = "Fecha y hora")]

        public DateTime FechaGEl { get; set; } 
        [Display(Name = "Gol equipo visitante")]

        public int GolEquipoVisita {get;set;}
        [Display(Name = "Fecha y hora")]

        public DateTime FechaGEV  { get; set; }  
        [Display(Name = "Marcador equipo local")]

        public int EquipoLocalMarca {get;set;}
        [Display(Name = "Marcador equipo visitante")]

        public int EquipoVisitaMarca {get;set;}
        [Display(Name = "Fecha y hora")]

        public DateTime FechaHora  { get; set; }                        
        // Relacion entre la Novedad y el Jugador Fk
        public Jugador Jugador { get; set; } 
        
    }
}