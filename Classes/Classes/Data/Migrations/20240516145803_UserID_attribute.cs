using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Classes.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserID_attribute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "AppUsers",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "AppUsers");
        }
    }
}
