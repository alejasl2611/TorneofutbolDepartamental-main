using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TorneoFutbolDptl.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arbitros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Colegio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arbitros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DirectorTecnicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectorTecnicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posiciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posiciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MunicipioId = table.Column<int>(type: "int", nullable: true),
                    DirectorTecnicoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipos_DirectorTecnicos_DirectorTecnicoId",
                        column: x => x.DirectorTecnicoId,
                        principalTable: "DirectorTecnicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipos_Municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estadios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MunicipioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estadios_Municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DesempenoEquipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartidosJugados = table.Column<int>(type: "int", nullable: false),
                    PartidosGanados = table.Column<int>(type: "int", nullable: false),
                    PartidosPerdidos = table.Column<int>(type: "int", nullable: false),
                    PartidosEmpatados = table.Column<int>(type: "int", nullable: false),
                    GolesAFavor = table.Column<int>(type: "int", nullable: false),
                    GolesEnContra = table.Column<int>(type: "int", nullable: false),
                    PuntosAcumulados = table.Column<int>(type: "int", nullable: false),
                    EquipoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesempenoEquipos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DesempenoEquipos_Equipos_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Jugadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipoId = table.Column<int>(type: "int", nullable: true),
                    PosicionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jugadores_Equipos_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Jugadores_Posiciones_PosicionId",
                        column: x => x.PosicionId,
                        principalTable: "Posiciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Novedades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TarjetaAmarilla = table.Column<int>(type: "int", nullable: false),
                    FechaHoraTA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TarjetaRoja = table.Column<int>(type: "int", nullable: false),
                    FechaHoraTR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GolEquipoLocal = table.Column<int>(type: "int", nullable: false),
                    FechaGEl = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GolEquipoVisita = table.Column<int>(type: "int", nullable: false),
                    FechaGEV = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EquipoLocalMarca = table.Column<int>(type: "int", nullable: false),
                    EquipoVisitaMarca = table.Column<int>(type: "int", nullable: false),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JugadorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Novedades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Novedades_Jugadores_JugadorId",
                        column: x => x.JugadorId,
                        principalTable: "Jugadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Partidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipoLocal = table.Column<int>(type: "int", nullable: false),
                    EquipoVisita = table.Column<int>(type: "int", nullable: false),
                    EquipoLocalMarca = table.Column<int>(type: "int", nullable: false),
                    EquipoVisitaMarca = table.Column<int>(type: "int", nullable: false),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArbitroId = table.Column<int>(type: "int", nullable: true),
                    EstadioId = table.Column<int>(type: "int", nullable: true),
                    NovedadId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Partidos_Arbitros_ArbitroId",
                        column: x => x.ArbitroId,
                        principalTable: "Arbitros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partidos_Estadios_EstadioId",
                        column: x => x.EstadioId,
                        principalTable: "Estadios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partidos_Novedades_NovedadId",
                        column: x => x.NovedadId,
                        principalTable: "Novedades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DesempenoEquipos_EquipoId",
                table: "DesempenoEquipos",
                column: "EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_DirectorTecnicoId",
                table: "Equipos",
                column: "DirectorTecnicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_MunicipioId",
                table: "Equipos",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Estadios_MunicipioId",
                table: "Estadios",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_EquipoId",
                table: "Jugadores",
                column: "EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_PosicionId",
                table: "Jugadores",
                column: "PosicionId");

            migrationBuilder.CreateIndex(
                name: "IX_Novedades_JugadorId",
                table: "Novedades",
                column: "JugadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_ArbitroId",
                table: "Partidos",
                column: "ArbitroId");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_EstadioId",
                table: "Partidos",
                column: "EstadioId");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_NovedadId",
                table: "Partidos",
                column: "NovedadId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DesempenoEquipos");

            migrationBuilder.DropTable(
                name: "Partidos");

            migrationBuilder.DropTable(
                name: "Arbitros");

            migrationBuilder.DropTable(
                name: "Estadios");

            migrationBuilder.DropTable(
                name: "Novedades");

            migrationBuilder.DropTable(
                name: "Jugadores");

            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
                name: "Posiciones");

            migrationBuilder.DropTable(
                name: "DirectorTecnicos");

            migrationBuilder.DropTable(
                name: "Municipios");
        }
    }
}
