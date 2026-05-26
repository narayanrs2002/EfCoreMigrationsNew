using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreMigrations.Migrations
{
    /// <inheritdoc />
    public partial class RenameTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EfMigrationE0146",
                table: "EfMigrationE0146");

            migrationBuilder.RenameTable(
                name: "EfMigrationE0146",
                newName: "EF_MIGRATION_E0146");

            migrationBuilder.AlterColumn<string>(
                name: "sex",
                table: "EF_MIGRATION_E0146",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<string>(
                name: "occupation",
                table: "EF_MIGRATION_E0146",
                type: "NVARCHAR2(2000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EF_MIGRATION_E0146",
                table: "EF_MIGRATION_E0146",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EF_MIGRATION_E0146",
                table: "EF_MIGRATION_E0146");

            migrationBuilder.RenameTable(
                name: "EF_MIGRATION_E0146",
                newName: "EfMigrationE0146");

            migrationBuilder.AlterColumn<string>(
                name: "sex",
                table: "EfMigrationE0146",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "occupation",
                table: "EfMigrationE0146",
                type: "NVARCHAR2(2000)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EfMigrationE0146",
                table: "EfMigrationE0146",
                column: "Id");
        }
    }
}
