using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomobiliuServisas.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Servisas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pavadinimas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vadovas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Miestas = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servisas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specializacija",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pavadinimas = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specializacija", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vartotojas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrisijungimoVardas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ElektroninisPastas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slaptazodis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vartotojas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meistras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vardas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pavarde = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nuotrauka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServisasId = table.Column<int>(type: "int", nullable: false),
                    SpecializacijaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meistras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meistras_Servisas_ServisasId",
                        column: x => x.ServisasId,
                        principalTable: "Servisas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Meistras_Specializacija_SpecializacijaId",
                        column: x => x.SpecializacijaId,
                        principalTable: "Specializacija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MeistroReitingas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeistrasId = table.Column<int>(type: "int", nullable: false),
                    VartotojasId = table.Column<int>(type: "int", nullable: false),
                    Balas = table.Column<int>(type: "int", nullable: false),
                    Komentaras = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeistroReitingas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeistroReitingas_Meistras_MeistrasId",
                        column: x => x.MeistrasId,
                        principalTable: "Meistras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MeistroReitingas_Vartotojas_VartotojasId",
                        column: x => x.VartotojasId,
                        principalTable: "Vartotojas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Meistras_ServisasId",
                table: "Meistras",
                column: "ServisasId");

            migrationBuilder.CreateIndex(
                name: "IX_Meistras_SpecializacijaId",
                table: "Meistras",
                column: "SpecializacijaId");

            migrationBuilder.CreateIndex(
                name: "IX_MeistroReitingas_MeistrasId",
                table: "MeistroReitingas",
                column: "MeistrasId");

            migrationBuilder.CreateIndex(
                name: "IX_MeistroReitingas_VartotojasId",
                table: "MeistroReitingas",
                column: "VartotojasId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeistroReitingas");

            migrationBuilder.DropTable(
                name: "Meistras");

            migrationBuilder.DropTable(
                name: "Vartotojas");

            migrationBuilder.DropTable(
                name: "Servisas");

            migrationBuilder.DropTable(
                name: "Specializacija");
        }
    }
}
