using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class changedtablenames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_shops_owners_ownerid",
                table: "shops");

            migrationBuilder.DropIndex(
                name: "IX_shops_ownerid",
                table: "shops");

            migrationBuilder.AlterColumn<int>(
                name: "ownerid",
                table: "shops",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ownerid",
                table: "shops",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_shops_ownerid",
                table: "shops",
                column: "ownerid");

            migrationBuilder.AddForeignKey(
                name: "FK_shops_owners_ownerid",
                table: "shops",
                column: "ownerid",
                principalTable: "owners",
                principalColumn: "Id");
        }
    }
}
