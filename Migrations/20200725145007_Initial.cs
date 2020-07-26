using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JWTTest.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    Habitantes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "Id", "Habitantes", "Nombre" },
                values: new object[,]
                {
                    { new Guid("fdfc67e3-6707-4b2e-a471-16555a24c619"), 46000000, "España" },
                    { new Guid("267e944e-ac88-4ee3-af04-8cb6161bf470"), 83000000, "Alemania" },
                    { new Guid("27ab0c03-ec6f-4e1e-8d85-7b77d4d723fb"), 65000000, "Francia" },
                    { new Guid("24a89b1b-c910-44dc-96db-09b300e3f549"), 61000000, "Italia" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paises");
        }
    }
}
