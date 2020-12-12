using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Scania.Br.KD.Api.Container.Schedule.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_ContainerType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(nullable: true),
                    ComprimentoExterno = table.Column<string>(nullable: true),
                    LarguraExterna = table.Column<string>(nullable: true),
                    AlturaExterna = table.Column<string>(nullable: true),
                    ComprimentoInterno = table.Column<string>(nullable: true),
                    LarguraInterna = table.Column<string>(nullable: true),
                    AlturaInterna = table.Column<string>(nullable: true),
                    CapacidadeM3 = table.Column<string>(nullable: true),
                    PesoMaximo = table.Column<string>(nullable: true),
                    DataDeGravacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_ContainerType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Dock",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Dock_Number = table.Column<int>(nullable: false),
                    Dock_Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Dock", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Line",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Line_Number = table.Column<int>(nullable: false),
                    Line_Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Line", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_Schedule_Container",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BatchId = table.Column<string>(nullable: true),
                    Container_Number = table.Column<string>(nullable: true),
                    Star_Date = table.Column<DateTime>(nullable: false),
                    End_Date = table.Column<DateTime>(nullable: false),
                    Line = table.Column<string>(nullable: true),
                    Dock = table.Column<int>(nullable: false),
                    Create_Date = table.Column<DateTime>(nullable: false),
                    Edit_Date = table.Column<DateTime>(nullable: true),
                    User_Create = table.Column<string>(nullable: true),
                    User_Edit = table.Column<string>(nullable: true),
                    Container_Type = table.Column<string>(nullable: true),
                    License_Plate = table.Column<string>(nullable: true),
                    Shipping_Company = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Schedule_Container", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_ContainerType");

            migrationBuilder.DropTable(
                name: "Tb_Dock");

            migrationBuilder.DropTable(
                name: "Tb_Line");

            migrationBuilder.DropTable(
                name: "TB_Schedule_Container");
        }
    }
}
