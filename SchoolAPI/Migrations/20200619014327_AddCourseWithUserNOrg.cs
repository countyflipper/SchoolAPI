using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class AddCourseWithUserNOrg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CourseID",
                table: "Users",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseID = table.Column<Guid>(nullable: false),
                    CourseName = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseID);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseID", "CourseName" },
                values: new object[] { new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"), "Web Systems Development" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseID", "CourseName" },
                values: new object[] { new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"), "	Web Services and Middleware" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseID", "CourseName" },
                values: new object[] { new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "	Enterprise Database Management" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                column: "CourseID",
                value: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                column: "CourseID",
                value: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                column: "CourseID",
                value: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"));

            migrationBuilder.CreateIndex(
                name: "IX_Users_CourseID",
                table: "Users",
                column: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Courses_CourseID",
                table: "Users",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Courses_CourseID",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Users_CourseID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Users");
        }
    }
}
