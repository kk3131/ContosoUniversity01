using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContosoUniversity01.Migrations
{
    /// <inheritdoc />
    public partial class InitFullSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Instructor_AdministratorInstructorId",
                table: "Department");

            migrationBuilder.RenameColumn(
                name: "InstructorId",
                table: "Instructor",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AdministratorInstructorId",
                table: "Department",
                newName: "InstructorID");

            migrationBuilder.RenameIndex(
                name: "IX_Department_AdministratorInstructorId",
                table: "Department",
                newName: "IX_Department_InstructorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Instructor_InstructorID",
                table: "Department",
                column: "InstructorID",
                principalTable: "Instructor",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Instructor_InstructorID",
                table: "Department");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Instructor",
                newName: "InstructorId");

            migrationBuilder.RenameColumn(
                name: "InstructorID",
                table: "Department",
                newName: "AdministratorInstructorId");

            migrationBuilder.RenameIndex(
                name: "IX_Department_InstructorID",
                table: "Department",
                newName: "IX_Department_AdministratorInstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Instructor_AdministratorInstructorId",
                table: "Department",
                column: "AdministratorInstructorId",
                principalTable: "Instructor",
                principalColumn: "InstructorId");
        }
    }
}
