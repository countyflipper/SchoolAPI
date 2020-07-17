using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class _070720200001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Courses_CourseID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CourseID",
                table: "Users");

            migrationBuilder.AddColumn<Guid>(
                name: "CoursesId",
                table: "Users",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 7, 21, 57, 31, 330, DateTimeKind.Local).AddTicks(7885), new DateTime(2020, 7, 7, 21, 57, 31, 330, DateTimeKind.Local).AddTicks(7883), new DateTime(2020, 7, 7, 21, 57, 31, 330, DateTimeKind.Local).AddTicks(7882), new DateTime(2020, 7, 7, 21, 57, 31, 330, DateTimeKind.Local).AddTicks(7887) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2447"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 7, 21, 57, 31, 330, DateTimeKind.Local).AddTicks(6992), new DateTime(2020, 7, 7, 21, 57, 31, 330, DateTimeKind.Local).AddTicks(6507), new DateTime(2020, 7, 7, 21, 57, 31, 330, DateTimeKind.Local).AddTicks(6050), new DateTime(2020, 7, 7, 21, 57, 31, 330, DateTimeKind.Local).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e04"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 7, 21, 57, 31, 330, DateTimeKind.Local).AddTicks(7864), new DateTime(2020, 7, 7, 21, 57, 31, 330, DateTimeKind.Local).AddTicks(7858), new DateTime(2020, 7, 7, 21, 57, 31, 330, DateTimeKind.Local).AddTicks(7842), new DateTime(2020, 7, 7, 21, 57, 31, 330, DateTimeKind.Local).AddTicks(7871) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 7, 21, 57, 31, 330, DateTimeKind.Local).AddTicks(2224), new DateTime(2020, 7, 7, 21, 57, 31, 330, DateTimeKind.Local).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 7, 21, 57, 31, 330, DateTimeKind.Local).AddTicks(1332), new DateTime(2020, 7, 7, 21, 57, 31, 330, DateTimeKind.Local).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 7, 21, 57, 31, 330, DateTimeKind.Local).AddTicks(2197), new DateTime(2020, 7, 7, 21, 57, 31, 330, DateTimeKind.Local).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("4fb597ea-72aa-4ddf-8d06-f009ad8a2d3a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 7, 21, 57, 31, 331, DateTimeKind.Local).AddTicks(8267), new DateTime(2020, 7, 7, 21, 57, 31, 331, DateTimeKind.Local).AddTicks(8688) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("a884663b-f3c7-46da-a541-9cef2ff12d66"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 7, 21, 57, 31, 331, DateTimeKind.Local).AddTicks(9900), new DateTime(2020, 7, 7, 21, 57, 31, 331, DateTimeKind.Local).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("df38bdf1-c93b-43e6-9ed1-0da79d774967"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 7, 21, 57, 31, 331, DateTimeKind.Local).AddTicks(9940), new DateTime(2020, 7, 7, 21, 57, 31, 331, DateTimeKind.Local).AddTicks(9942) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("3f6e887a-40f1-4032-a347-5c526d7ca36d"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 7, 21, 57, 31, 331, DateTimeKind.Local).AddTicks(2539), new DateTime(2020, 7, 7, 21, 57, 31, 331, DateTimeKind.Local).AddTicks(2124), new DateTime(2020, 7, 7, 21, 57, 31, 331, DateTimeKind.Local).AddTicks(1661), new DateTime(2020, 7, 7, 21, 57, 31, 331, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("a6a002f5-7d7b-4a3c-977b-cd78f55252bf"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 7, 21, 57, 31, 331, DateTimeKind.Local).AddTicks(3565), new DateTime(2020, 7, 7, 21, 57, 31, 331, DateTimeKind.Local).AddTicks(3564), new DateTime(2020, 7, 7, 21, 57, 31, 331, DateTimeKind.Local).AddTicks(3562), new DateTime(2020, 7, 7, 21, 57, 31, 331, DateTimeKind.Local).AddTicks(3567) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("b880cf73-b029-4c6d-ae21-6ee0a7a8e243"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 7, 21, 57, 31, 331, DateTimeKind.Local).AddTicks(3547), new DateTime(2020, 7, 7, 21, 57, 31, 331, DateTimeKind.Local).AddTicks(3540), new DateTime(2020, 7, 7, 21, 57, 31, 331, DateTimeKind.Local).AddTicks(3523), new DateTime(2020, 7, 7, 21, 57, 31, 331, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 7, 21, 57, 31, 329, DateTimeKind.Local).AddTicks(6809), new DateTime(2020, 7, 7, 21, 57, 31, 329, DateTimeKind.Local).AddTicks(6811) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 7, 21, 57, 31, 329, DateTimeKind.Local).AddTicks(5008), new DateTime(2020, 7, 7, 21, 57, 31, 329, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 7, 21, 57, 31, 329, DateTimeKind.Local).AddTicks(6763), new DateTime(2020, 7, 7, 21, 57, 31, 329, DateTimeKind.Local).AddTicks(6782) });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CoursesId",
                table: "Users",
                column: "CoursesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Courses_CoursesId",
                table: "Users",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Courses_CoursesId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CoursesId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CoursesId",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 25, 18, 31, 52, 899, DateTimeKind.Local).AddTicks(5757), new DateTime(2020, 6, 25, 18, 31, 52, 899, DateTimeKind.Local).AddTicks(5756), new DateTime(2020, 6, 25, 18, 31, 52, 899, DateTimeKind.Local).AddTicks(5754), new DateTime(2020, 6, 25, 18, 31, 52, 899, DateTimeKind.Local).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2447"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 25, 18, 31, 52, 899, DateTimeKind.Local).AddTicks(4896), new DateTime(2020, 6, 25, 18, 31, 52, 899, DateTimeKind.Local).AddTicks(4489), new DateTime(2020, 6, 25, 18, 31, 52, 899, DateTimeKind.Local).AddTicks(4054), new DateTime(2020, 6, 25, 18, 31, 52, 899, DateTimeKind.Local).AddTicks(5284) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e04"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 25, 18, 31, 52, 899, DateTimeKind.Local).AddTicks(5736), new DateTime(2020, 6, 25, 18, 31, 52, 899, DateTimeKind.Local).AddTicks(5730), new DateTime(2020, 6, 25, 18, 31, 52, 899, DateTimeKind.Local).AddTicks(5711), new DateTime(2020, 6, 25, 18, 31, 52, 899, DateTimeKind.Local).AddTicks(5743) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 25, 18, 31, 52, 898, DateTimeKind.Local).AddTicks(9885), new DateTime(2020, 6, 25, 18, 31, 52, 898, DateTimeKind.Local).AddTicks(9888) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 25, 18, 31, 52, 898, DateTimeKind.Local).AddTicks(8932), new DateTime(2020, 6, 25, 18, 31, 52, 898, DateTimeKind.Local).AddTicks(9349) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 25, 18, 31, 52, 898, DateTimeKind.Local).AddTicks(9781), new DateTime(2020, 6, 25, 18, 31, 52, 898, DateTimeKind.Local).AddTicks(9801) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("4fb597ea-72aa-4ddf-8d06-f009ad8a2d3a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 25, 18, 31, 52, 900, DateTimeKind.Local).AddTicks(7457), new DateTime(2020, 6, 25, 18, 31, 52, 900, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("a884663b-f3c7-46da-a541-9cef2ff12d66"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 25, 18, 31, 52, 900, DateTimeKind.Local).AddTicks(9212), new DateTime(2020, 6, 25, 18, 31, 52, 900, DateTimeKind.Local).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("df38bdf1-c93b-43e6-9ed1-0da79d774967"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 25, 18, 31, 52, 900, DateTimeKind.Local).AddTicks(9256), new DateTime(2020, 6, 25, 18, 31, 52, 900, DateTimeKind.Local).AddTicks(9258) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("3f6e887a-40f1-4032-a347-5c526d7ca36d"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 25, 18, 31, 52, 900, DateTimeKind.Local).AddTicks(1250), new DateTime(2020, 6, 25, 18, 31, 52, 900, DateTimeKind.Local).AddTicks(764), new DateTime(2020, 6, 25, 18, 31, 52, 900, DateTimeKind.Local).AddTicks(265), new DateTime(2020, 6, 25, 18, 31, 52, 900, DateTimeKind.Local).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("a6a002f5-7d7b-4a3c-977b-cd78f55252bf"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 25, 18, 31, 52, 900, DateTimeKind.Local).AddTicks(2204), new DateTime(2020, 6, 25, 18, 31, 52, 900, DateTimeKind.Local).AddTicks(2202), new DateTime(2020, 6, 25, 18, 31, 52, 900, DateTimeKind.Local).AddTicks(2200), new DateTime(2020, 6, 25, 18, 31, 52, 900, DateTimeKind.Local).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("b880cf73-b029-4c6d-ae21-6ee0a7a8e243"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 25, 18, 31, 52, 900, DateTimeKind.Local).AddTicks(2181), new DateTime(2020, 6, 25, 18, 31, 52, 900, DateTimeKind.Local).AddTicks(2174), new DateTime(2020, 6, 25, 18, 31, 52, 900, DateTimeKind.Local).AddTicks(2155), new DateTime(2020, 6, 25, 18, 31, 52, 900, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 25, 18, 31, 52, 898, DateTimeKind.Local).AddTicks(4371), new DateTime(2020, 6, 25, 18, 31, 52, 898, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 25, 18, 31, 52, 898, DateTimeKind.Local).AddTicks(2598), new DateTime(2020, 6, 25, 18, 31, 52, 898, DateTimeKind.Local).AddTicks(3051) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 25, 18, 31, 52, 898, DateTimeKind.Local).AddTicks(4318), new DateTime(2020, 6, 25, 18, 31, 52, 898, DateTimeKind.Local).AddTicks(4339) });

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
    }
}
