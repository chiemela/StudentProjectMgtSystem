using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentProjectMgtSystem.Migrations
{
    public partial class NewModules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Modules_ModulesID",
                table: "Enrollment");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Students_StudentsID",
                table: "Enrollment");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Modules_ModulesID",
                table: "Instructor");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Enrollment_StudentsID",
                table: "Enrollment");

            migrationBuilder.DropColumn(
                name: "StudentsID",
                table: "Enrollment");

            migrationBuilder.RenameColumn(
                name: "ModulesID",
                table: "Instructor",
                newName: "ModuleID");

            migrationBuilder.RenameIndex(
                name: "IX_Instructor_ModulesID",
                table: "Instructor",
                newName: "IX_Instructor_ModuleID");

            migrationBuilder.RenameColumn(
                name: "ModulesID",
                table: "Enrollment",
                newName: "ModuleID");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollment_ModulesID",
                table: "Enrollment",
                newName: "IX_Enrollment_ModuleID");

            migrationBuilder.CreateTable(
                name: "Module",
                columns: table => new
                {
                    ModuleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstructorID = table.Column<int>(type: "int", nullable: false),
                    DurationInWeeks = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Module", x => x.ModuleID);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsLoggedIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnrollmentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_StudentID",
                table: "Enrollment",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Module_ModuleID",
                table: "Enrollment",
                column: "ModuleID",
                principalTable: "Module",
                principalColumn: "ModuleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Student_StudentID",
                table: "Enrollment",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Module_ModuleID",
                table: "Instructor",
                column: "ModuleID",
                principalTable: "Module",
                principalColumn: "ModuleID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Module_ModuleID",
                table: "Enrollment");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Student_StudentID",
                table: "Enrollment");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Module_ModuleID",
                table: "Instructor");

            migrationBuilder.DropTable(
                name: "Module");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Enrollment_StudentID",
                table: "Enrollment");

            migrationBuilder.RenameColumn(
                name: "ModuleID",
                table: "Instructor",
                newName: "ModulesID");

            migrationBuilder.RenameIndex(
                name: "IX_Instructor_ModuleID",
                table: "Instructor",
                newName: "IX_Instructor_ModulesID");

            migrationBuilder.RenameColumn(
                name: "ModuleID",
                table: "Enrollment",
                newName: "ModulesID");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollment_ModuleID",
                table: "Enrollment",
                newName: "IX_Enrollment_ModulesID");

            migrationBuilder.AddColumn<int>(
                name: "StudentsID",
                table: "Enrollment",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    ModulesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DurationInWeeks = table.Column<int>(type: "int", nullable: false),
                    InstructorID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.ModulesID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnrollmentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsLoggedIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentsID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_StudentsID",
                table: "Enrollment",
                column: "StudentsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Modules_ModulesID",
                table: "Enrollment",
                column: "ModulesID",
                principalTable: "Modules",
                principalColumn: "ModulesID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Students_StudentsID",
                table: "Enrollment",
                column: "StudentsID",
                principalTable: "Students",
                principalColumn: "StudentsID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Modules_ModulesID",
                table: "Instructor",
                column: "ModulesID",
                principalTable: "Modules",
                principalColumn: "ModulesID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
