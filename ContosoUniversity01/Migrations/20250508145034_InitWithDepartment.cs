using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContosoUniversity01.Migrations
{
    /// <inheritdoc />
    public partial class InitWithDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Department_DepartmentID",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Instructor_InstructorId",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_InstructorId",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "InstructorId",
                table: "Course");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentID",
                table: "Course",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "CourseInstructor",
                columns: table => new
                {
                    CoursesCourseID = table.Column<int>(type: "int", nullable: false),
                    InstructorsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseInstructor", x => new { x.CoursesCourseID, x.InstructorsId });
                    table.ForeignKey(
                        name: "FK_CourseInstructor_Course_CoursesCourseID",
                        column: x => x.CoursesCourseID,
                        principalTable: "Course",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseInstructor_Instructor_InstructorsId",
                        column: x => x.InstructorsId,
                        principalTable: "Instructor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseInstructor_InstructorsId",
                table: "CourseInstructor",
                column: "InstructorsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Department_DepartmentID",
                table: "Course",
                column: "DepartmentID",
                principalTable: "Department",
                principalColumn: "DepartmentID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Department_DepartmentID",
                table: "Course");

            migrationBuilder.DropTable(
                name: "CourseInstructor");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentID",
                table: "Course",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "InstructorId",
                table: "Course",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Course_InstructorId",
                table: "Course",
                column: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Department_DepartmentID",
                table: "Course",
                column: "DepartmentID",
                principalTable: "Department",
                principalColumn: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Instructor_InstructorId",
                table: "Course",
                column: "InstructorId",
                principalTable: "Instructor",
                principalColumn: "Id");
        }
    }
}
