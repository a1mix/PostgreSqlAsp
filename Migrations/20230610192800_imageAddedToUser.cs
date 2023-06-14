using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostgreSqlAsp.Migrations
{
    /// <inheritdoc />
    public partial class imageAddedToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Users",
                type: "text",
                nullable: true,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "Birthday",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
