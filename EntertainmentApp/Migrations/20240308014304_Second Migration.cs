using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntertainmentApp.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Genre_Name",
                table: "Genres",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "navarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Artist",
                table: "Albums",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "navarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "AlbumType",
                table: "Albums",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "navarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "AlbumName",
                table: "Albums",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "navarchar(100)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Genre_Name",
                table: "Genres",
                type: "navarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Artist",
                table: "Albums",
                type: "navarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "AlbumType",
                table: "Albums",
                type: "navarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "AlbumName",
                table: "Albums",
                type: "navarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");
        }
    }
}
