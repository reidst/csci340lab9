using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HendrixUniversity.Migrations
{
    /// <inheritdoc />
    public partial class LabChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "Student",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "age",
                table: "Student");
        }
    }
}
