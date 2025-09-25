using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Schoolsystem.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedTeacherDateOfHire : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBith",
                table: "Teachers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfHire",
                table: "Teachers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBith",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "DateOfHire",
                table: "Teachers");
        }
    }
}
