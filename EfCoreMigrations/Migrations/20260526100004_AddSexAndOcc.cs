using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreMigrations.Migrations
{
    /// <inheritdoc />
    public partial class AddSexAndOcc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "occupation",
                table: "EfMigrationE0146",
                type: "NVARCHAR2(2000)",
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "sex",
                table: "EfMigrationE0146",
                type: "NVARCHAR2(2000)",
                nullable: true,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "occupation",
                table: "EfMigrationE0146");

            migrationBuilder.DropColumn(
                name: "sex",
                table: "EfMigrationE0146");
        }
    }
}
