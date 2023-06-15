using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rc_service.Migrations
{
    public partial class BDmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo_Estado = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logeo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Contraseña = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logeo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    Id_Servicio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo_Servicio = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Detalles_Servicio = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Servicio__5B1345F06B68D6DB", x => x.Id_Servicio);
                });

            migrationBuilder.CreateTable(
                name: "Ubicacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pais = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Departamento = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Municipio = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Barrio = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Direccion = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubicacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prestadores_de_servicios",
                columns: table => new
                {
                    Id_Prestador = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Name_Prestador = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Lastname_Prestador = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Celular = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Ubicacion_Id = table.Column<int>(type: "int", nullable: false),
                    Servicios_Id_Servicio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Prestado__25950CC5C9132033", x => x.Id_Prestador);
                    table.ForeignKey(
                        name: "FK__Prestador__Servi__44FF419A",
                        column: x => x.Servicios_Id_Servicio,
                        principalTable: "Servicios",
                        principalColumn: "Id_Servicio");
                    table.ForeignKey(
                        name: "FK__Prestador__Ubica__440B1D61",
                        column: x => x.Ubicacion_Id,
                        principalTable: "Ubicacion",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Propietarios",
                columns: table => new
                {
                    Id_Propietario = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Name_Propietario = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Lastname_Propietario = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Celular = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Ubicacion_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Propieta__7360E97D53E2D633", x => x.Id_Propietario);
                    table.ForeignKey(
                        name: "FK__Propietar__Ubica__3B75D760",
                        column: x => x.Ubicacion_Id,
                        principalTable: "Ubicacion",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Inmuebles",
                columns: table => new
                {
                    Id_Inmueble = table.Column<int>(type: "int", nullable: false),
                    Tipo_Inmueble = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Detalles_Inmueble = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Ubicacion_Id = table.Column<int>(type: "int", nullable: false),
                    Propietarios_Id_Propietario = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Inmueble__DB51280D21ABBE03", x => x.Id_Inmueble);
                    table.ForeignKey(
                        name: "FK__Inmuebles__Propi__3F466844",
                        column: x => x.Propietarios_Id_Propietario,
                        principalTable: "Propietarios",
                        principalColumn: "Id_Propietario");
                    table.ForeignKey(
                        name: "FK__Inmuebles__Ubica__3E52440B",
                        column: x => x.Ubicacion_Id,
                        principalTable: "Ubicacion",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ofertas",
                columns: table => new
                {
                    Id_Ofertas = table.Column<int>(type: "int", nullable: false),
                    Inmuebles_Id_Inmueble = table.Column<int>(type: "int", nullable: false),
                    Servicios_Id_Servicio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Ofertas__C41D869B0AF968BA", x => x.Id_Ofertas);
                    table.ForeignKey(
                        name: "FK__Ofertas__Inmuebl__47DBAE45",
                        column: x => x.Inmuebles_Id_Inmueble,
                        principalTable: "Inmuebles",
                        principalColumn: "Id_Inmueble");
                    table.ForeignKey(
                        name: "FK__Ofertas__Servici__48CFD27E",
                        column: x => x.Servicios_Id_Servicio,
                        principalTable: "Servicios",
                        principalColumn: "Id_Servicio");
                });

            migrationBuilder.CreateTable(
                name: "Contratacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ofertas_Id_Ofertas = table.Column<int>(type: "int", nullable: false),
                    Estados_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contratacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Contratac__Estad__4E88ABD4",
                        column: x => x.Estados_Id,
                        principalTable: "Estados",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Contratac__Ofert__4D94879B",
                        column: x => x.Ofertas_Id_Ofertas,
                        principalTable: "Ofertas",
                        principalColumn: "Id_Ofertas");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contratacion_Estados_Id",
                table: "Contratacion",
                column: "Estados_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Contratacion_Ofertas_Id_Ofertas",
                table: "Contratacion",
                column: "Ofertas_Id_Ofertas");

            migrationBuilder.CreateIndex(
                name: "IX_Inmuebles_Propietarios_Id_Propietario",
                table: "Inmuebles",
                column: "Propietarios_Id_Propietario");

            migrationBuilder.CreateIndex(
                name: "IX_Inmuebles_Ubicacion_Id",
                table: "Inmuebles",
                column: "Ubicacion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Ofertas_Inmuebles_Id_Inmueble",
                table: "Ofertas",
                column: "Inmuebles_Id_Inmueble");

            migrationBuilder.CreateIndex(
                name: "IX_Ofertas_Servicios_Id_Servicio",
                table: "Ofertas",
                column: "Servicios_Id_Servicio");

            migrationBuilder.CreateIndex(
                name: "IX_Prestadores_de_servicios_Servicios_Id_Servicio",
                table: "Prestadores_de_servicios",
                column: "Servicios_Id_Servicio");

            migrationBuilder.CreateIndex(
                name: "IX_Prestadores_de_servicios_Ubicacion_Id",
                table: "Prestadores_de_servicios",
                column: "Ubicacion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Propietarios_Ubicacion_Id",
                table: "Propietarios",
                column: "Ubicacion_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contratacion");

            migrationBuilder.DropTable(
                name: "Logeo");

            migrationBuilder.DropTable(
                name: "Prestadores_de_servicios");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "Ofertas");

            migrationBuilder.DropTable(
                name: "Inmuebles");

            migrationBuilder.DropTable(
                name: "Servicios");

            migrationBuilder.DropTable(
                name: "Propietarios");

            migrationBuilder.DropTable(
                name: "Ubicacion");
        }
    }
}
