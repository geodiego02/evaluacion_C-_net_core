using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ENA_Rodrigo_Vera_3600.Migrations
{
    public partial class primeraMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Rut = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Fono = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "ControlMascotas",
                columns: table => new
                {
                    ControlMascotasId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCliente = table.Column<string>(nullable: true),
                    NombreMascota = table.Column<string>(nullable: true),
                    TipoMascota = table.Column<string>(nullable: true),
                    RazaMascota = table.Column<string>(nullable: true),
                    Detalle = table.Column<string>(nullable: true),
                    Servicio = table.Column<string>(nullable: true),
                    ProgramaVacuna = table.Column<string>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Total = table.Column<int>(nullable: false),
                    FechaAtencion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlMascotas", x => x.ControlMascotasId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreUsuario = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Cargo = table.Column<string>(nullable: true),
                    Contraseña = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Mascota",
                columns: table => new
                {
                    MascotaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoMascota = table.Column<string>(nullable: true),
                    RazaMascota = table.Column<string>(nullable: true),
                    SexoMascota = table.Column<string>(nullable: true),
                    VacunasMascota = table.Column<string>(nullable: true),
                    ColorMascota = table.Column<string>(nullable: true),
                    NombreMascota = table.Column<string>(nullable: true),
                    EdadMascota = table.Column<int>(nullable: false),
                    ClienteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mascota", x => x.MascotaId);
                    table.ForeignKey(
                        name: "FK_Mascota_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TablaIntermedia",
                columns: table => new
                {
                    ClienteId = table.Column<int>(nullable: false),
                    ControlMascotasId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaIntermedia", x => new { x.ClienteId, x.ControlMascotasId });
                    table.ForeignKey(
                        name: "FK_TablaIntermedia_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TablaIntermedia_ControlMascotas_ControlMascotasId",
                        column: x => x.ControlMascotasId,
                        principalTable: "ControlMascotas",
                        principalColumn: "ControlMascotasId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mascota_ClienteId",
                table: "Mascota",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_TablaIntermedia_ControlMascotasId",
                table: "TablaIntermedia",
                column: "ControlMascotasId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mascota");

            migrationBuilder.DropTable(
                name: "TablaIntermedia");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "ControlMascotas");
        }
    }
}
