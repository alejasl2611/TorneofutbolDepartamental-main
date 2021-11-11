using System;
using System.Collections.Generic;

using TorneoFutbolDptl.App.Dominio;
using TorneoFutbolDptl.App.Persistencia;

namespace TorneoFutbolDptl.App.Consola
{
    class Program
    {
        private static IRepositorioMunicipio _repoMunicipio = new RepositorioMunicipio();
        private static IRepositorioPosicion _repoPosicion = new RepositorioPosicion();
        private static IRepositorioEstadio _repoEstadio = new RepositorioEstadio();
        private static IRepositorioDirectorTecnico _repoDirectorTecnico = new RepositorioDirectorTecnico();
        private static IRepositorioEquipo _repoEquipo = new RepositorioEquipo();
        private static IRepositorioJugador _repoJugador = new RepositorioJugador();
        private static IRepositorioArbitro _repoArbitro = new RepositorioArbitro();
        private static IRepositorioNovedad _repoNovedad = new RepositorioNovedad();
        private static IRepositorioPartido _repoPartido = new RepositorioPartido();
        private static IRepositorioDesempenoEquipo _repoDesempenoEquipo = new RepositorioDesempenoEquipo();          
        static void Main(string[] args)

        {
            Console.WriteLine("Hello World!");
            //AddMunicipio();
            //BuscarMunicipio(1);
            //EliminarMunicipio(3);
            //MostrarMunicipios();
            // UpdateMunicipio(); 
//------------------------------------------------
            //AddPosicion();           
            //BuscarPosicion(3);
            //EliminarPosicion(3);
            //MostrarPosiciones();
            //UpdatePosicion();                                  
//--------------------------------------------------------
            //AddEstadio();           
            //BuscarEstadio(3);
            //EliminarEstadio(3);
            //MostrarEstadio();
            // UpdateEstadio(); 
            //AsignarMunicipio();
//------------------------------------------------------
            //AddDirectorTecnico();
            //BuscarDirectorTecnico(2);
            //EliminarDirectorTecnico(3);
            //MostrarDirectorTecnicos();
            //UpdateDirectorTecnico();             
//----------------------------------------------------
            //AddEquipo();           
            //BuscarEquipo(2);
            //EliminarEquipo(3);
            //MostrarEquipo();
             //UpdateEquipo(); 
            //AsignarMunicipioEquipo();
            //AsignarDirectorTecnico();
//----------------------------------------------------
            //AddJugador();           
            //BuscarJugador(3);
            //EliminarJugador(3);
           // MostrarJugador();
            // UpdateJugador(); 
            //AsignarEquipoJugador();
            //AsignarPosicionJugador();
//----------------------------------------------------
            //AddArbitro();           
            //BuscarArbitro(1);
            //EliminarArbitro(3);
            //MostrarArbitros();
            // UpdateArbitro(); 
//----------------------------------------------------
            //AddNovedad();           
            //BuscarNovedad(1);
            //EliminarNovedad(3);
            //MostrarNovedades();
            //UpdateNovedad(); 
            //AsignarJugador();
//----------------------------------------------------
           //AddPartido();           
            //BuscarPartido(2);
            //EliminarPartido(3);
            //MostrarPartido();
             //UpdatePartido(); 
            //AsignarArbitroPartido();
            //AsignarEstadioPartido();
            //AsignarNovedadPartido();
//----------------------------------------------------
            //AddDesempenoEquipo();           
            //BuscarDesempenoEquipo(1);
            //EliminarDesempenoEquipo(3);
            //MostrarDesempenoEquipo();
            //UpdateDesempenoEquipo(); 
            //AsignarEquipo();
//----------------------------------------------------
        }
        private static void AddMunicipio()
        {
            var municipio = new Municipio
            {
                Nombre = "Neira",
            };
            _repoMunicipio.AddMunicipio(municipio);
        }
        private static void BuscarMunicipio(int idMunicipio)
        {
            var municipio =  _repoMunicipio.GetMunicipio(idMunicipio);
            Console.WriteLine(municipio.Nombre);
        }          

        private static void EliminarMunicipio(int idMunicipio)
        {
            _repoMunicipio.DeleteMunicipio(idMunicipio);
            Console.WriteLine("Municipio Eliminado");
        }

        private static void MostrarMunicipios()
        {
            IEnumerable<Municipio> municipios = _repoMunicipio.GetAllMunicipios();
            foreach (var municipio in municipios)
            {
                Console.WriteLine(municipio.Nombre);
            }
        }
         private  static void UpdateMunicipio()
         {
            var municipio = _repoMunicipio.GetMunicipio(5);
            Console.WriteLine(municipio.Nombre);
             municipio.Nombre = "Salamina";
            Console.WriteLine(municipio.Nombre);             
             _repoMunicipio.UpdateMunicipio(municipio);
         }        
//----------------------------------------------------------------------------------------
        private static void AddPosicion()
        {
            var posicion = new Posicion
            {
                Nombre = "Defensa",
            };
            _repoPosicion.AddPosicion(posicion);
        }
        private static void BuscarPosicion(int idPosicion)
        {
            var posicion = _repoPosicion.GetPosicion(idPosicion);
            Console.WriteLine(posicion.Nombre);
        }          

        private static void EliminarPosicion(int idPosicion)
        {
            _repoPosicion.DeletePosicion(idPosicion);
            Console.WriteLine("Posicion Eliminada");
        }

        private static void MostrarPosiciones()
        {
            IEnumerable<Posicion> posiciones = _repoPosicion.GetAllPosiciones();
            foreach (var posicion in posiciones)
            {
                Console.WriteLine(posicion.Nombre);
            }
        }

         private  static void UpdatePosicion()
         {
            var posicion = _repoPosicion.GetPosicion(1);
            Console.WriteLine(posicion.Nombre);
             posicion.Nombre = "Porteros";
            Console.WriteLine(posicion.Nombre);             
             _repoPosicion.UpdatePosicion(posicion);
         }  
       
//---------------------------------------------------------------------

        private static void AddEstadio()
        {
            var estadio = new Estadio
            {
                Nombre = "Palogrande",
                Direccion = "calle Abajo",
                //Municipio = "Aguadas",  
            };
            _repoEstadio.AddEstadio(estadio);
        }
        private static void BuscarEstadio(int idEstadio)
        {
            var estadio =  _repoEstadio.GetEstadio(idEstadio);
            Console.WriteLine(estadio.Nombre);
        }          

        private static void EliminarEstadio(int idEstadio)
        {
            _repoEstadio.DeleteEstadio(idEstadio);
            Console.WriteLine("Estadio Eliminado");
        }

        private static void MostrarEstadioes()
        {
            IEnumerable<Estadio> estadios = _repoEstadio.GetAllEstadios();
            foreach (var estadio in estadios)
            {
                Console.WriteLine(estadio.Nombre);
            }
        }

        private static void AsignarMunicipio()
        {
            var municipio = _repoEstadio.AsignarMunicipio(1,3);
            Console.WriteLine(municipio.Nombre);
        }

         private  static void UpdateEstadio()
         {
            var estadio = _repoEstadio.GetEstadio(3);
            Console.WriteLine(estadio.Nombre);
             estadio.Nombre = "PaloMediano";
             estadio.Direccion = "En el alto";
            Console.WriteLine(estadio.Nombre);             
             _repoEstadio.UpdateEstadio(estadio);
         }

//--------------------------- -------        

        private static void AddDirectorTecnico()
        {
            var directorTecnico = new DirectorTecnico
            {
                Nombre = "luis Perez",
                Documento = "5555555",
                NumeroTelefono = "6394939",
            };
            _repoDirectorTecnico.AddDirectorTecnico(directorTecnico);
        }
        private static void BuscarDirectorTecnico(int idDirectorTecnico)
        {
            var directorTecnico =  _repoDirectorTecnico.GetDirectorTecnico(idDirectorTecnico);
            Console.WriteLine(directorTecnico.Nombre);
        }          

        private static void EliminarDirectorTecnico(int idDirectorTecnico)
        {
            _repoDirectorTecnico.DeleteDirectorTecnico(idDirectorTecnico);
            Console.WriteLine("DirectorTecnico Eliminado");
        }

        private static void MostrarDirectorTecnicos()
        {
            IEnumerable<DirectorTecnico> directorTecnicos = _repoDirectorTecnico.GetAllDirectorTecnicos();
            foreach (var directorTecnico in directorTecnicos)
            {
                Console.WriteLine(directorTecnico.Nombre);
            }
        }
         private  static void UpdateDirectorTecnico()
         {
            var directorTecnico = _repoDirectorTecnico.GetDirectorTecnico(2);
            Console.WriteLine(directorTecnico.Nombre);
            Console.WriteLine(directorTecnico.Documento);
            Console.WriteLine(directorTecnico.NumeroTelefono);
             directorTecnico.Nombre = "Juan";
             //directorTecnico.Documento = "6455555",
             //directorTecnico.NumeroTelefono = "5394938",
            Console.WriteLine(directorTecnico.Nombre);             
             _repoDirectorTecnico.UpdateDirectorTecnico(directorTecnico);
         }

//-------------------------------------------------------------------------------

        private static void AddEquipo()
        {
            var equipo = new Equipo
            {
                Nombre = "Medellin",
            };
            _repoEquipo.AddEquipo(equipo);
        }
        private static void BuscarEquipo(int idEquipo)
        {
            var equipo =  _repoEquipo.GetEquipo(idEquipo);
            Console.WriteLine(equipo.Nombre);
        }          

        private static void EliminarEquipo(int idEquipo)
        {
            _repoEquipo.DeleteEquipo(idEquipo);
            Console.WriteLine("Equipo Eliminado");
        }

        private static void MostrarEquipo()
        {
            IEnumerable<Equipo> equipos = _repoEquipo.GetAllEquipos();
            foreach (var equipo in equipos)
            {
                Console.WriteLine(equipo.Nombre);
            }
        }

        private static void AsignarMunicipioEquipo()
        {
            var municipio = _repoEquipo.AsignarMunicipioEquipo(1,1);
            Console.WriteLine(municipio.Nombre);
        }

        private static void AsignarDirectorTecnico()
        {
            var directorTecnico = _repoEquipo.AsignarDirectorTecnico(1,2);
            Console.WriteLine(directorTecnico.Nombre);
        }


        private  static void UpdateEquipo()
        {
            var equipo = _repoEquipo.GetEquipo(2);
            Console.WriteLine(equipo.Nombre);
             equipo.Nombre = "Medellin";
            Console.WriteLine(equipo.Nombre);             
             _repoEquipo.UpdateEquipo(equipo);
        }

//-------------------------------------------------------------------------------

        private static void AddJugador()
        {
            var jugador = new Jugador
            {
             Nombre = "Juan",
             Numero = "11",
            };
            _repoJugador.AddJugador(jugador);
        }
        private static void BuscarJugador(int idJugador)
        {
            var jugador =  _repoJugador.GetJugador(idJugador);
            Console.WriteLine(jugador.Nombre);
        }          

        private static void EliminarJugador(int idJugador)
        {
            _repoJugador.DeleteJugador(idJugador);
            Console.WriteLine("Jugador Eliminado");
        }

        private static void MostrarJugador()
        {
            IEnumerable<Jugador> jugadores = _repoJugador.GetAllJugadores();
            foreach (var jugador in jugadores)
            {
                Console.WriteLine(jugador.Nombre);
                Console.WriteLine(jugador.Numero);
                Console.WriteLine(jugador.Equipo);
                Console.WriteLine(jugador.Posicion);
            }
        }

        private static void AsignarEquipoJugador()
        {
            var equipo = _repoJugador.AsignarEquipoJugador(1,1);
            Console.WriteLine(equipo.Nombre);
        }

        private static void AsignarPosicionJugador()
        {
            var posicion = _repoJugador.AsignarPosicionJugador(1,1);
            Console.WriteLine(posicion.Nombre);
        }


        private  static void UpdateJugador()
        {
            var jugador = _repoJugador.GetJugador(2);
            Console.WriteLine(jugador.Nombre);
             jugador.Nombre = "Carlos";
             jugador.Numero = "10";
            Console.WriteLine(jugador.Nombre);             
             _repoJugador.UpdateJugador(jugador);
        } 

//-------------------------------------------------------------------------------

        private static void AddArbitro()
        {
            var arbitro = new Arbitro
            {
                Nombre = "Arbitro 1",
                Documento = "5555555",
                telefono = "6394939",
                Colegio = "ASFC"
            };
            _repoArbitro.AddArbitro(arbitro);
        }
        private static void BuscarArbitro(int idArbitro)
        {
            var arbitro =  _repoArbitro.GetArbitro(idArbitro);
            Console.WriteLine(arbitro.Nombre);
        }          

        private static void EliminarArbitro(int idArbitro)
        {
            _repoArbitro.DeleteArbitro(idArbitro);
            Console.WriteLine("Arbitro Eliminado");
        }

        private static void MostrarArbitros()
        {
            IEnumerable<Arbitro> arbitros = _repoArbitro.GetAllArbitros();
            foreach (var arbitro in arbitros)
            {
                Console.WriteLine(arbitro.Nombre);
            }
        }
         private  static void UpdateArbitro()
         {
            var arbitro = _repoArbitro.GetArbitro(2);
            Console.WriteLine(arbitro.Nombre);
            Console.WriteLine(arbitro.Documento);
            Console.WriteLine(arbitro.telefono);
            Console.WriteLine(arbitro.Colegio);            
             arbitro.Nombre = "arbitro 3";
             //arbitro.Documento = "6455555",
             //arbitro.telefono = "5394938",
             //arbitro.Colegio = "dfgh",             
            Console.WriteLine(arbitro.Nombre);             
             _repoArbitro.UpdateArbitro(arbitro);
         }
//-------------------------------------------------------------------------------

       private static void AddNovedad()
        {
            var novedad = new Novedad
            {
                TarjetaAmarilla = 0,
               // FechaHoraTA =,
                TarjetaRoja = 0,
                //FechaHoraTR = Null,
                GolEquipoLocal = 0,
                //FechaGEl = Null,
                GolEquipoVisita = 0,
               //FechaGEV = Null,
                EquipoLocalMarca = 0,
                EquipoVisitaMarca = 0,
                //FechaHora = "Null",
            };
            _repoNovedad.AddNovedad(novedad);
        }
        private static void BuscarNovedad(int idNovedad)
        {
            var novedad =  _repoNovedad.GetNovedad(idNovedad);
            Console.WriteLine(novedad.Id);
        }          

        private static void EliminarNovedad(int idNovedad)
        {
            _repoNovedad.DeleteNovedad(idNovedad);
            Console.WriteLine("Novedad Eliminado");
        }

        private static void MostrarNovedades()
        {
            IEnumerable<Novedad> novedades = _repoNovedad.GetAllNovedades();
            foreach (var novedad in novedades)
            {
                Console.WriteLine(novedad.Id);
            }
        }

        private static void AsignarJugador()
        {
            var Jugador = _repoNovedad.AsignarJugador(1,1);
            Console.WriteLine(Jugador.Nombre);
        }


        private  static void UpdateNovedad()
         {
            var novedad = _repoNovedad.GetNovedad(1);
            Console.WriteLine(novedad.TarjetaAmarilla);
            Console.WriteLine(novedad.FechaHoraTA);
            Console.WriteLine(novedad.TarjetaRoja);
            Console.WriteLine(novedad.FechaHoraTR);
            Console.WriteLine(novedad.GolEquipoLocal);
            Console.WriteLine(novedad.FechaGEl);
            Console.WriteLine(novedad.GolEquipoVisita);
            Console.WriteLine(novedad.FechaGEV);
            Console.WriteLine(novedad.EquipoLocalMarca);
            Console.WriteLine(novedad.EquipoVisitaMarca);
            Console.WriteLine(novedad.FechaHora);

            //novedad.TarjetaAmarilla = 1;
            string value = "2021-09-27 03:21:00";
            novedad.FechaHoraTA = Convert.ToDateTime(value);
            //novedad.TarjetaRoja = 1,
            //novedad.FechaHoraTR = Null,
            //novedad.GolEquipoLocal 1
            //novedad.FechaGEl = Nul,
            //novedad.GolEquipoVisita = 1,
            //novedad.FechaGEV = Null,
            //novedad.EquipoLocalMarca = 1,
            //novedad.EquipoVisitaMarca = 1,
            //novedad.FechaHora = "Null",

            Console.WriteLine(novedad.TarjetaAmarilla);
            Console.WriteLine(novedad.FechaHoraTA);
            Console.WriteLine(novedad.TarjetaRoja);
            Console.WriteLine(novedad.FechaHoraTR);
            Console.WriteLine(novedad.GolEquipoLocal);
            Console.WriteLine(novedad.FechaGEl);
            Console.WriteLine(novedad.GolEquipoVisita);
            Console.WriteLine(novedad.FechaGEV);
            Console.WriteLine(novedad.EquipoLocalMarca);
            Console.WriteLine(novedad.EquipoVisitaMarca);
            Console.WriteLine(novedad.FechaHora);

            _repoNovedad.UpdateNovedad(novedad);
         }
//-------------------------------------------------------------------------------         

        private static void AddPartido()
        {
            var partido = new Partido
            {
                EquipoLocal = 2,
                EquipoVisita = 1,
                EquipoLocalMarca = 0,
                EquipoVisitaMarca = 0,
            };
            _repoPartido.AddPartido(partido);
        }
        private static void BuscarPartido(int idPartido)
        {
            var partido =  _repoPartido.GetPartido(idPartido);
            Console.WriteLine(partido.Id);
        }          

        private static void EliminarPartido(int idPartido)
        {
            _repoPartido.DeletePartido(idPartido);
            Console.WriteLine("Partido Eliminado");
        }

        private static void MostrarPartido()
        {
            IEnumerable<Partido> partidos = _repoPartido.GetAllPartidos();
            foreach (var partido in partidos)
            {
                Console.WriteLine(partido.Id);
            }
        }

        private static void AsignarArbitroPartido()
        {
            var arbitro = _repoPartido.AsignarArbitroPartido(1,1);
            Console.WriteLine(arbitro.Nombre);
        }

        private static void AsignarEstadioPartido()
        {
            var estadio = _repoPartido.AsignarEstadioPartido(1,2);
            Console.WriteLine(estadio.Nombre);
        }

        private static void AsignarNovedadPartido()
        {
            var novedad = _repoPartido.AsignarNovedadPartido(1,1);
            Console.WriteLine(novedad.Id);
        }

        private  static void UpdatePartido()
        {
            var partido = _repoPartido.GetPartido(1);
            Console.WriteLine(partido.EquipoLocal);
            Console.WriteLine(partido.EquipoVisita);
            Console.WriteLine(partido.EquipoLocalMarca);
            Console.WriteLine(partido.EquipoVisitaMarca);
            Console.WriteLine(partido.FechaHora);
            Console.WriteLine(partido.Arbitro);
            Console.WriteLine(partido.Estadio);
            Console.WriteLine(partido.Novedades);

            // partido.EquipoLocal = 3;
            //partido.EquipoVisita = "Nacionalll"; 
            // partido.EquipoLocalMarca = 2;
             //partido.EquipoVisitaMarca =5;  
             string value = "2021-09-27 07:45:00";
             partido.FechaHora = Convert.ToDateTime(value);                                      
             
            Console.WriteLine(partido.EquipoLocal);
            Console.WriteLine(partido.EquipoVisita);
            Console.WriteLine(partido.EquipoLocalMarca);
            Console.WriteLine(partido.EquipoVisitaMarca);
            Console.WriteLine(partido.FechaHora);
            _repoPartido.UpdatePartido(partido);

        }
//-------------------------------------------------------------------------------         
       private static void AddDesempenoEquipo()
        {
            var desempenoEquipo = new DesempenoEquipo
            {
                PartidosJugados = 0,
                PartidosGanados = 0,
                PartidosPerdidos = 0,
                PartidosEmpatados = 0,
                GolesAFavor = 0,
                GolesEnContra = 0,
                PuntosAcumulados = 0,                
            };
            _repoDesempenoEquipo.AddDesempenoEquipo(desempenoEquipo);
        }
        private static void BuscarDesempenoEquipo(int idDesempenoEquipo)
        {
            var desempenoEquipo =  _repoDesempenoEquipo.GetDesempenoEquipo(idDesempenoEquipo);
            Console.WriteLine(desempenoEquipo.Id);
        }          

        private static void EliminarDesempenoEquipo(int idDesempenoEquipo)
        {
            _repoDesempenoEquipo.DeleteDesempenoEquipo(idDesempenoEquipo);
            Console.WriteLine("DesempenoEquipo Eliminado");
        }

        private static void MostrarDesempenoEquipo()
        {
            IEnumerable<DesempenoEquipo> desempenoEquipos = _repoDesempenoEquipo.GetAllDesempenoEquipo();
            foreach (var desempenoEquipo in desempenoEquipos)
            {
                Console.WriteLine(desempenoEquipo.Id);
            }
        }

        private static void AsignarEquipo()
        {
            var Equipo = _repoDesempenoEquipo.AsignarEquipo(1,1);
            Console.WriteLine(Equipo.Nombre);
        }


        private  static void UpdateDesempenoEquipo()
         {
            var desempenoEquipo = _repoDesempenoEquipo.GetDesempenoEquipo(1);
            Console.WriteLine(desempenoEquipo.PartidosJugados);
            Console.WriteLine(desempenoEquipo.PartidosGanados);
            Console.WriteLine(desempenoEquipo.PartidosPerdidos);
            Console.WriteLine(desempenoEquipo.PartidosEmpatados);
            Console.WriteLine(desempenoEquipo.GolesAFavor);
            Console.WriteLine(desempenoEquipo.GolesEnContra);
            Console.WriteLine(desempenoEquipo.PuntosAcumulados);

            //desempenoEquipo.PartidosJugados = 1;
            //desempenoEquipo.PartidosGanados = 1;
            //desempenoEquipo.PartidosPerdidos = 1;
            //desempenoEquipo.PartidosEmpatados = 1;
            //desempenoEquipo..GolesAFavor = 1;
            //desempenoEquipo..GolesEnContra = 1;            
            //desempenoEquipo.PuntosAcumulados = 1;

            Console.WriteLine(desempenoEquipo.PartidosJugados);
            Console.WriteLine(desempenoEquipo.PartidosGanados);
            Console.WriteLine(desempenoEquipo.PartidosPerdidos);
            Console.WriteLine(desempenoEquipo.PartidosEmpatados);
            Console.WriteLine(desempenoEquipo.GolesAFavor);
            Console.WriteLine(desempenoEquipo.GolesEnContra);
            Console.WriteLine(desempenoEquipo.PuntosAcumulados);
            _repoDesempenoEquipo.UpdateDesempenoEquipo(desempenoEquipo);
         }        
    }            
}