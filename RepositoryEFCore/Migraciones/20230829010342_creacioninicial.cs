using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryEFCore.Migraciones
{
    /// <inheritdoc />
    public partial class creacioninicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CodSedeIPSDemo",
                columns: table => new
                {
                    IdCodSedeIPSDemo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodSedeIPSDemo", x => x.IdCodSedeIPSDemo);
                });

            migrationBuilder.CreateTable(
                name: "DNTClasificacionNutricional",
                columns: table => new
                {
                    IdDNTClasificacionNutricional = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DNTClasificacionNutricional", x => x.IdDNTClasificacionNutricional);
                });

            migrationBuilder.CreateTable(
                name: "DNTManejo",
                columns: table => new
                {
                    IdDNTManejo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DNTManejo", x => x.IdDNTManejo);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    IdPersona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoIdentificacion = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    NroIdentificacion = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false),
                    PrimerNombre = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    SegundoNombre = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    PrimerApellido = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    SegundoApellido = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CodMpioResidencia = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CodAsegurador = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.IdPersona);
                });

            migrationBuilder.CreateTable(
                name: "Seguimientos",
                columns: table => new
                {
                    IdSeguimiento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPersona = table.Column<int>(type: "int", nullable: false),
                    PersonaIdPersona = table.Column<int>(type: "int", nullable: false),
                    estadoVital = table.Column<int>(type: "int", nullable: false),
                    FechaDefuncion = table.Column<DateTime>(type: "Date", nullable: false),
                    ubicacionDefuncion = table.Column<int>(type: "int", nullable: false),
                    CodLugarAtencion = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    CodSedeIPSDemoIdCodSedeIPSDemo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FechaAtencion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PesoKg = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    TallaCm = table.Column<short>(type: "smallint", nullable: false),
                    CodClasificacionNutricional = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    CodManejoActual = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguimientos", x => x.IdSeguimiento);
                    table.ForeignKey(
                        name: "FK_Seguimientos_CodSedeIPSDemo_CodSedeIPSDemoIdCodSedeIPSDemo",
                        column: x => x.CodSedeIPSDemoIdCodSedeIPSDemo,
                        principalTable: "CodSedeIPSDemo",
                        principalColumn: "IdCodSedeIPSDemo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Seguimientos_DNTClasificacionNutricional_CodClasificacionNutricional",
                        column: x => x.CodClasificacionNutricional,
                        principalTable: "DNTClasificacionNutricional",
                        principalColumn: "IdDNTClasificacionNutricional",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Seguimientos_DNTManejo_CodManejoActual",
                        column: x => x.CodManejoActual,
                        principalTable: "DNTManejo",
                        principalColumn: "IdDNTManejo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Seguimientos_Personas_PersonaIdPersona",
                        column: x => x.PersonaIdPersona,
                        principalTable: "Personas",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Seguimientos_CodClasificacionNutricional",
                table: "Seguimientos",
                column: "CodClasificacionNutricional");

            migrationBuilder.CreateIndex(
                name: "IX_Seguimientos_CodManejoActual",
                table: "Seguimientos",
                column: "CodManejoActual");

            migrationBuilder.CreateIndex(
                name: "IX_Seguimientos_CodSedeIPSDemoIdCodSedeIPSDemo",
                table: "Seguimientos",
                column: "CodSedeIPSDemoIdCodSedeIPSDemo");

            migrationBuilder.CreateIndex(
                name: "IX_Seguimientos_PersonaIdPersona",
                table: "Seguimientos",
                column: "PersonaIdPersona");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Seguimientos");

            migrationBuilder.DropTable(
                name: "CodSedeIPSDemo");

            migrationBuilder.DropTable(
                name: "DNTClasificacionNutricional");

            migrationBuilder.DropTable(
                name: "DNTManejo");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
