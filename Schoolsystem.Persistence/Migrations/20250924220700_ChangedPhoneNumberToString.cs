using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Schoolsystem.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ChangedPhoneNumberToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "phoneNumber",
                table: "Students",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "fullName",
                table: "Students",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "dateOfEnrollement",
                table: "Students",
                newName: "DateOfEnrollement");

            migrationBuilder.RenameColumn(
                name: "dateOfBirth",
                table: "Students",
                newName: "DateOfBirth");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Students",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Students",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Students",
                newName: "phoneNumber");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Students",
                newName: "fullName");

            migrationBuilder.RenameColumn(
                name: "DateOfEnrollement",
                table: "Students",
                newName: "dateOfEnrollement");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "Students",
                newName: "dateOfBirth");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Students",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Students",
                newName: "id");

            migrationBuilder.AlterColumn<int>(
                name: "phoneNumber",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "fullName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "address",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
