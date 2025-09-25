using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Schoolsystem.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class TeacherUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Qulification",
                table: "Teachers",
                newName: "Qualification");

            migrationBuilder.RenameColumn(
                name: "DateOfBith",
                table: "Teachers",
                newName: "DateOfBirth");

            migrationBuilder.AlterColumn<string>(
                name: "TeacherName",
                table: "Teachers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Qualification",
                table: "Teachers",
                newName: "Qulification");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "Teachers",
                newName: "DateOfBith");

            migrationBuilder.AlterColumn<string>(
                name: "TeacherName",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
