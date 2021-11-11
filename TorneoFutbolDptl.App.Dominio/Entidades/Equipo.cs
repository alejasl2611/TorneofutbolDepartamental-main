namespace TorneoFutbolDptl.App.Dominio
{
    public class Equipo
    {
        // Identificador único de cada Equipo
        public int Id { get; set; }
        public string Nombre { get; set; }
        // Relacion entre Equipo y el municipio Fk
        public Municipio Municipio {get; set;}
        // Relacion entre Equipo y DT  Fk
        public DirectorTecnico DirectorTecnico { get; set; }
    }
}
