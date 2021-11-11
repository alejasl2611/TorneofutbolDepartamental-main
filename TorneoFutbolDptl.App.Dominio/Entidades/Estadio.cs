namespace TorneoFutbolDptl.App.Dominio
{
    public class Estadio
    {
        // Identificador único de cada estadio
        public int Id { get; set; }
        public string Nombre {get;set;}
        public string Direccion {get;set;}
        // Relacion entre estadio y el municipio Fk
        public Municipio Municipio { get; set;}
        
    }
}
