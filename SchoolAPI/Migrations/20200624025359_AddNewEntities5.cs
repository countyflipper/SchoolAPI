using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class AddNewEntities5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SystemRoleID",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 53, 58, 765, DateTimeKind.Local).AddTicks(752), new DateTime(2020, 6, 23, 22, 53, 58, 765, DateTimeKind.Local).AddTicks(750), new DateTime(2020, 6, 23, 22, 53, 58, 765, DateTimeKind.Local).AddTicks(748), new DateTime(2020, 6, 23, 22, 53, 58, 765, DateTimeKind.Local).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2447"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 53, 58, 764, DateTimeKind.Local).AddTicks(9812), new DateTime(2020, 6, 23, 22, 53, 58, 764, DateTimeKind.Local).AddTicks(9371), new DateTime(2020, 6, 23, 22, 53, 58, 764, DateTimeKind.Local).AddTicks(8877), new DateTime(2020, 6, 23, 22, 53, 58, 765, DateTimeKind.Local).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e04"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 53, 58, 765, DateTimeKind.Local).AddTicks(730), new DateTime(2020, 6, 23, 22, 53, 58, 765, DateTimeKind.Local).AddTicks(722), new DateTime(2020, 6, 23, 22, 53, 58, 765, DateTimeKind.Local).AddTicks(703), new DateTime(2020, 6, 23, 22, 53, 58, 765, DateTimeKind.Local).AddTicks(736) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 53, 58, 764, DateTimeKind.Local).AddTicks(4207), new DateTime(2020, 6, 23, 22, 53, 58, 764, DateTimeKind.Local).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 53, 58, 764, DateTimeKind.Local).AddTicks(3118), new DateTime(2020, 6, 23, 22, 53, 58, 764, DateTimeKind.Local).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 53, 58, 764, DateTimeKind.Local).AddTicks(4177), new DateTime(2020, 6, 23, 22, 53, 58, 764, DateTimeKind.Local).AddTicks(4195) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("4fb597ea-72aa-4ddf-8d06-f009ad8a2d3a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 53, 58, 766, DateTimeKind.Local).AddTicks(2497), new DateTime(2020, 6, 23, 22, 53, 58, 766, DateTimeKind.Local).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("a884663b-f3c7-46da-a541-9cef2ff12d66"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 53, 58, 766, DateTimeKind.Local).AddTicks(3457), new DateTime(2020, 6, 23, 22, 53, 58, 766, DateTimeKind.Local).AddTicks(3476) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("df38bdf1-c93b-43e6-9ed1-0da79d774967"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 53, 58, 766, DateTimeKind.Local).AddTicks(3488), new DateTime(2020, 6, 23, 22, 53, 58, 766, DateTimeKind.Local).AddTicks(3491) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("3f6e887a-40f1-4032-a347-5c526d7ca36d"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 53, 58, 765, DateTimeKind.Local).AddTicks(6358), new DateTime(2020, 6, 23, 22, 53, 58, 765, DateTimeKind.Local).AddTicks(5905), new DateTime(2020, 6, 23, 22, 53, 58, 765, DateTimeKind.Local).AddTicks(5410), new DateTime(2020, 6, 23, 22, 53, 58, 765, DateTimeKind.Local).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("a6a002f5-7d7b-4a3c-977b-cd78f55252bf"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 53, 58, 765, DateTimeKind.Local).AddTicks(7308), new DateTime(2020, 6, 23, 22, 53, 58, 765, DateTimeKind.Local).AddTicks(7306), new DateTime(2020, 6, 23, 22, 53, 58, 765, DateTimeKind.Local).AddTicks(7304), new DateTime(2020, 6, 23, 22, 53, 58, 765, DateTimeKind.Local).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("b880cf73-b029-4c6d-ae21-6ee0a7a8e243"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 53, 58, 765, DateTimeKind.Local).AddTicks(7282), new DateTime(2020, 6, 23, 22, 53, 58, 765, DateTimeKind.Local).AddTicks(7274), new DateTime(2020, 6, 23, 22, 53, 58, 765, DateTimeKind.Local).AddTicks(7254), new DateTime(2020, 6, 23, 22, 53, 58, 765, DateTimeKind.Local).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "Email", "Password", "Status", "SystemRoleID", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 53, 58, 763, DateTimeKind.Local).AddTicks(6847), "stussel@njit.edu", "newyork1", "Active", 8000007, new DateTime(2020, 6, 23, 22, 53, 58, 763, DateTimeKind.Local).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                columns: new[] { "CreatedDate", "Email", "Password", "Status", "SystemRoleID", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 53, 58, 763, DateTimeKind.Local).AddTicks(4588), "sderosa@njit.edu", "pass123", "Active", 2000001, new DateTime(2020, 6, 23, 22, 53, 58, 763, DateTimeKind.Local).AddTicks(5216) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                columns: new[] { "CreatedDate", "Email", "Password", "Status", "SystemRoleID", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 53, 58, 763, DateTimeKind.Local).AddTicks(6779), "zwaltz@njit.edu", "hippo87", "Active", 3000008, new DateTime(2020, 6, 23, 22, 53, 58, 763, DateTimeKind.Local).AddTicks(6799) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SystemRoleID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(2720), new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(2718), new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(2716), new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(2721) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2447"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(1826), new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(1436), new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(1013), new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(2246) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e04"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(2700), new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(2693), new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(2677), new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 48, 6, 149, DateTimeKind.Local).AddTicks(7199), new DateTime(2020, 6, 23, 22, 48, 6, 149, DateTimeKind.Local).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 48, 6, 149, DateTimeKind.Local).AddTicks(6298), new DateTime(2020, 6, 23, 22, 48, 6, 149, DateTimeKind.Local).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 48, 6, 149, DateTimeKind.Local).AddTicks(7170), new DateTime(2020, 6, 23, 22, 48, 6, 149, DateTimeKind.Local).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("4fb597ea-72aa-4ddf-8d06-f009ad8a2d3a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 48, 6, 151, DateTimeKind.Local).AddTicks(2712), new DateTime(2020, 6, 23, 22, 48, 6, 151, DateTimeKind.Local).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("a884663b-f3c7-46da-a541-9cef2ff12d66"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 48, 6, 151, DateTimeKind.Local).AddTicks(3959), new DateTime(2020, 6, 23, 22, 48, 6, 151, DateTimeKind.Local).AddTicks(3977) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("df38bdf1-c93b-43e6-9ed1-0da79d774967"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 48, 6, 151, DateTimeKind.Local).AddTicks(3990), new DateTime(2020, 6, 23, 22, 48, 6, 151, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("3f6e887a-40f1-4032-a347-5c526d7ca36d"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(7260), new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(6870), new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(6442), new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("a6a002f5-7d7b-4a3c-977b-cd78f55252bf"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(8079), new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(8078), new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(8076), new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(8081) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("b880cf73-b029-4c6d-ae21-6ee0a7a8e243"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(8061), new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(8054), new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(8036), new DateTime(2020, 6, 23, 22, 48, 6, 150, DateTimeKind.Local).AddTicks(8068) });
        }
    }
}
