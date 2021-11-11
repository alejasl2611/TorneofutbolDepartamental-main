using System;
using System.ComponentModel.DataAnnotations;

namespace TorneoFutbolDptl.App.Dominio
{
    public class Partido
    {
        // Identificador único de cada Partido
        public int Id { get; set; }
       [Display(Name = "Equipo local")]
        public int EquipoLocal {get;set;}
        [Display(Name = "Equipo visitante")]
        public int EquipoVisita {get;set;}
       [Display(Name = "Marcador Equipo local")]
        public int EquipoLocalMarca {get;set;}
       [Display(Name = "Marcador Equipo visitante")]
        public int EquipoVisitaMarca {get;set;}
       [Display(Name = "Fecha y hora")]
        public DateTime FechaHora  { get; set; }                        
        // Relacion entre Partido y el Arbitro Fk
       [Display(Name = "Árbitro")]
        public Arbitro Arbitro { get; set; } 
        // Relacion entre Partido y el Estadio Fk
        public Estadio Estadio { get; set; } 
        // Relacion entre la Partido y la Novedad Fk
        public Novedad Novedad { get; set; }  
                       
    }
}