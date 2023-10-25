using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DomenicaEscobar_ExamenP1.Migrations
{
    public partial class DomenicaEscobar_DB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DomenicaEscobar_Tabla",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DENombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DEPrecio = table.Column<bool>(type: "bit", nullable: false),
                    DEConTocino = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DEFecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DomenicaEscobar_Tabla", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DomenicaEscobar_Tabla");
        }
    }
}
