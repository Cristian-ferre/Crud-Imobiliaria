using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace imobiliaria.Migrations
{
    public partial class CriaçãoDeTabelaPropertyType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PropertyTypeId",
                table: "Properties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "PropertyTypeId1",
                table: "Properties",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PropertyType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Properties_PropertyTypeId1",
                table: "Properties",
                column: "PropertyTypeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_PropertyType_PropertyTypeId1",
                table: "Properties",
                column: "PropertyTypeId1",
                principalTable: "PropertyType",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_PropertyType_PropertyTypeId1",
                table: "Properties");

            migrationBuilder.DropTable(
                name: "PropertyType");

            migrationBuilder.DropIndex(
                name: "IX_Properties_PropertyTypeId1",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "PropertyTypeId",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "PropertyTypeId1",
                table: "Properties");
        }
    }
}
