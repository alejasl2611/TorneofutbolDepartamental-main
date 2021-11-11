namespace TorneoFutbolDptl.App.Dominio
{
    public class DesempenoEquipo
    {
        // Identificador único de cada Desempeño
        public int Id { get; set; }
        public int PartidosJugados {get;set;}
        public int PartidosGanados {get;set;}
        public int PartidosPerdidos {get;set;}
        public int PartidosEmpatados {get;set;}
        public int GolesAFavor {get;set;}
        public int GolesEnContra {get;set;}
        public int PuntosAcumulados {get;set;}
        // Relacion entre el DesempenoEquipo y equipo FK
        public Equipo Equipo { get; set; }
        
    }
}
