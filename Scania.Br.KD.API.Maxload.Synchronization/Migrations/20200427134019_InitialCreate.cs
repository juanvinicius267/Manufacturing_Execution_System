using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Scania.Br.KD.API.Maxload.Synchronization.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_Maxload",
                columns: table => new
                {
                    MaxloadId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BatchId = table.Column<string>(nullable: true),
                    ContainerNum = table.Column<int>(nullable: false),
                    Component = table.Column<string>(nullable: true),
                    MuCode = table.Column<string>(nullable: true),
                    BoxeNumber = table.Column<string>(nullable: true),
                    PriorityNumber = table.Column<int>(nullable: false),
                    PriorityNumber2 = table.Column<int>(nullable: false),
                    SavedHour = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Maxload", x => x.MaxloadId);
                });

            migrationBuilder.CreateTable(
                name: "Tb_RoundsRule",
                columns: table => new
                {
                    RoundsId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Component = table.Column<string>(nullable: true),
                    MuCode = table.Column<string>(nullable: true),
                    CabRounds = table.Column<int>(nullable: false),
                    SkdRounds = table.Column<int>(nullable: false),
                    SkidRounds = table.Column<int>(nullable: false),
                    EcuRounds = table.Column<int>(nullable: false),
                    CabLine = table.Column<bool>(nullable: false),
                    SkdLine = table.Column<bool>(nullable: false),
                    SkidLine = table.Column<bool>(nullable: false),
                    EcuLine = table.Column<bool>(nullable: false),
                    CabDock = table.Column<bool>(nullable: false),
                    SkdDock = table.Column<bool>(nullable: false),
                    SkidDock = table.Column<bool>(nullable: false),
                    EcuDock = table.Column<bool>(nullable: false),
                    SavedHour = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_RoundsRule", x => x.RoundsId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_Maxload");

            migrationBuilder.DropTable(
                name: "Tb_RoundsRule");
        }
    }
}
