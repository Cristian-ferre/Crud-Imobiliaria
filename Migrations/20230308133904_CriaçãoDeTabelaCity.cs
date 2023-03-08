using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace imobiliaria.Migrations
{
    public partial class CriaçãoDeTabelaCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Properties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "CityId1",
                table: "Properties",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CEPCyty = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Properties_CityId1",
                table: "Properties",
                column: "CityId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_City_CityId1",
                table: "Properties",
                column: "CityId1",
                principalTable: "City",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_City_CityId1",
                table: "Properties");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropIndex(
                name: "IX_Properties_CityId1",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "CityId1",
                table: "Properties");
        }
    }
}
