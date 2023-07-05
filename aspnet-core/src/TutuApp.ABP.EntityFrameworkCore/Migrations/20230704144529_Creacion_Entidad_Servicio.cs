using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TutuApp.ABP.Migrations
{
    /// <inheritdoc />
    public partial class CreacionEntidadServicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppServicios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nombre = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    Precio = table.Column<double>(type: "double precision", nullable: false),
                    Duracion = table.Column<int>(type: "integer", nullable: false),
                    TipoDeServicio = table.Column<int>(type: "integer", nullable: false),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppServicios", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppServicios");
        }
    }
}
