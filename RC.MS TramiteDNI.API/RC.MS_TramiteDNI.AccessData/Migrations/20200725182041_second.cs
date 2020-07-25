using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RC.MS_TramiteDNI.AccessData.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TramiteNacimientos",
                columns: table => new
                {
                    TramiteNacimientoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TramiteNacimientos", x => x.TramiteNacimientoId);
                });

            migrationBuilder.CreateTable(
                name: "RecienNacidos",
                columns: table => new
                {
                    RecienNacidoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Persona_1_Id = table.Column<int>(nullable: false),
                    Persona_2_Id = table.Column<int>(nullable: false),
                    NumeroActa = table.Column<int>(nullable: false),
                    Genero = table.Column<string>(maxLength: 250, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    LugarNacimiento = table.Column<string>(maxLength: 250, nullable: false),
                    PartidaNacimiento = table.Column<bool>(nullable: false),
                    TramiteNacimientoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecienNacidos", x => x.RecienNacidoId);
                    table.ForeignKey(
                        name: "FK_RecienNacidos_TramiteNacimientos_TramiteNacimientoId",
                        column: x => x.TramiteNacimientoId,
                        principalTable: "TramiteNacimientos",
                        principalColumn: "TramiteNacimientoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecienNacidos_TramiteNacimientoId",
                table: "RecienNacidos",
                column: "TramiteNacimientoId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecienNacidos");

            migrationBuilder.DropTable(
                name: "TramiteNacimientos");
        }
    }
}
