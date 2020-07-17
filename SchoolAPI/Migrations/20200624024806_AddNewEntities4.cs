using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class AddNewEntities4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 37, 46, 877, DateTimeKind.Local).AddTicks(6727), new DateTime(2020, 6, 23, 22, 37, 46, 877, DateTimeKind.Local).AddTicks(6725), new DateTime(2020, 6, 23, 22, 37, 46, 877, DateTimeKind.Local).AddTicks(6723), new DateTime(2020, 6, 23, 22, 37, 46, 877, DateTimeKind.Local).AddTicks(6728) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2447"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 37, 46, 877, DateTimeKind.Local).AddTicks(5599), new DateTime(2020, 6, 23, 22, 37, 46, 877, DateTimeKind.Local).AddTicks(5205), new DateTime(2020, 6, 23, 22, 37, 46, 877, DateTimeKind.Local).AddTicks(4768), new DateTime(2020, 6, 23, 22, 37, 46, 877, DateTimeKind.Local).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e04"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 37, 46, 877, DateTimeKind.Local).AddTicks(6707), new DateTime(2020, 6, 23, 22, 37, 46, 877, DateTimeKind.Local).AddTicks(6699), new DateTime(2020, 6, 23, 22, 37, 46, 877, DateTimeKind.Local).AddTicks(6682), new DateTime(2020, 6, 23, 22, 37, 46, 877, DateTimeKind.Local).AddTicks(6714) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 37, 46, 877, DateTimeKind.Local).AddTicks(1005), new DateTime(2020, 6, 23, 22, 37, 46, 877, DateTimeKind.Local).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 37, 46, 876, DateTimeKind.Local).AddTicks(9853), new DateTime(2020, 6, 23, 22, 37, 46, 877, DateTimeKind.Local).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 37, 46, 877, DateTimeKind.Local).AddTicks(974), new DateTime(2020, 6, 23, 22, 37, 46, 877, DateTimeKind.Local).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("4fb597ea-72aa-4ddf-8d06-f009ad8a2d3a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 37, 46, 878, DateTimeKind.Local).AddTicks(6490), new DateTime(2020, 6, 23, 22, 37, 46, 878, DateTimeKind.Local).AddTicks(6896) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("a884663b-f3c7-46da-a541-9cef2ff12d66"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 37, 46, 878, DateTimeKind.Local).AddTicks(7315), new DateTime(2020, 6, 23, 22, 37, 46, 878, DateTimeKind.Local).AddTicks(7333) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("df38bdf1-c93b-43e6-9ed1-0da79d774967"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 37, 46, 878, DateTimeKind.Local).AddTicks(7343), new DateTime(2020, 6, 23, 22, 37, 46, 878, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("3f6e887a-40f1-4032-a347-5c526d7ca36d"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 37, 46, 878, DateTimeKind.Local).AddTicks(1311), new DateTime(2020, 6, 23, 22, 37, 46, 878, DateTimeKind.Local).AddTicks(890), new DateTime(2020, 6, 23, 22, 37, 46, 878, DateTimeKind.Local).AddTicks(413), new DateTime(2020, 6, 23, 22, 37, 46, 878, DateTimeKind.Local).AddTicks(1697) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("a6a002f5-7d7b-4a3c-977b-cd78f55252bf"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 37, 46, 878, DateTimeKind.Local).AddTicks(2152), new DateTime(2020, 6, 23, 22, 37, 46, 878, DateTimeKind.Local).AddTicks(2151), new DateTime(2020, 6, 23, 22, 37, 46, 878, DateTimeKind.Local).AddTicks(2149), new DateTime(2020, 6, 23, 22, 37, 46, 878, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("b880cf73-b029-4c6d-ae21-6ee0a7a8e243"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 37, 46, 878, DateTimeKind.Local).AddTicks(2133), new DateTime(2020, 6, 23, 22, 37, 46, 878, DateTimeKind.Local).AddTicks(2124), new DateTime(2020, 6, 23, 22, 37, 46, 878, DateTimeKind.Local).AddTicks(2107), new DateTime(2020, 6, 23, 22, 37, 46, 878, DateTimeKind.Local).AddTicks(2140) });
        }
    }
}
