using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class GetData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 53, 1, 938, DateTimeKind.Local).AddTicks(3999), new DateTime(2020, 6, 24, 18, 53, 1, 938, DateTimeKind.Local).AddTicks(3997), new DateTime(2020, 6, 24, 18, 53, 1, 938, DateTimeKind.Local).AddTicks(3996), new DateTime(2020, 6, 24, 18, 53, 1, 938, DateTimeKind.Local).AddTicks(4001) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2447"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 53, 1, 938, DateTimeKind.Local).AddTicks(3150), new DateTime(2020, 6, 24, 18, 53, 1, 938, DateTimeKind.Local).AddTicks(2757), new DateTime(2020, 6, 24, 18, 53, 1, 938, DateTimeKind.Local).AddTicks(2310), new DateTime(2020, 6, 24, 18, 53, 1, 938, DateTimeKind.Local).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e04"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 53, 1, 938, DateTimeKind.Local).AddTicks(3980), new DateTime(2020, 6, 24, 18, 53, 1, 938, DateTimeKind.Local).AddTicks(3972), new DateTime(2020, 6, 24, 18, 53, 1, 938, DateTimeKind.Local).AddTicks(3957), new DateTime(2020, 6, 24, 18, 53, 1, 938, DateTimeKind.Local).AddTicks(3986) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 53, 1, 937, DateTimeKind.Local).AddTicks(8549), new DateTime(2020, 6, 24, 18, 53, 1, 937, DateTimeKind.Local).AddTicks(8551) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 53, 1, 937, DateTimeKind.Local).AddTicks(7606), new DateTime(2020, 6, 24, 18, 53, 1, 937, DateTimeKind.Local).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 53, 1, 937, DateTimeKind.Local).AddTicks(8517), new DateTime(2020, 6, 24, 18, 53, 1, 937, DateTimeKind.Local).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("4fb597ea-72aa-4ddf-8d06-f009ad8a2d3a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 53, 1, 939, DateTimeKind.Local).AddTicks(4499), new DateTime(2020, 6, 24, 18, 53, 1, 939, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("a884663b-f3c7-46da-a541-9cef2ff12d66"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 53, 1, 939, DateTimeKind.Local).AddTicks(6048), new DateTime(2020, 6, 24, 18, 53, 1, 939, DateTimeKind.Local).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("df38bdf1-c93b-43e6-9ed1-0da79d774967"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 53, 1, 939, DateTimeKind.Local).AddTicks(6086), new DateTime(2020, 6, 24, 18, 53, 1, 939, DateTimeKind.Local).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("3f6e887a-40f1-4032-a347-5c526d7ca36d"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 53, 1, 938, DateTimeKind.Local).AddTicks(8663), new DateTime(2020, 6, 24, 18, 53, 1, 938, DateTimeKind.Local).AddTicks(8263), new DateTime(2020, 6, 24, 18, 53, 1, 938, DateTimeKind.Local).AddTicks(7761), new DateTime(2020, 6, 24, 18, 53, 1, 938, DateTimeKind.Local).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("a6a002f5-7d7b-4a3c-977b-cd78f55252bf"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 53, 1, 938, DateTimeKind.Local).AddTicks(9496), new DateTime(2020, 6, 24, 18, 53, 1, 938, DateTimeKind.Local).AddTicks(9494), new DateTime(2020, 6, 24, 18, 53, 1, 938, DateTimeKind.Local).AddTicks(9492), new DateTime(2020, 6, 24, 18, 53, 1, 938, DateTimeKind.Local).AddTicks(9498) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("b880cf73-b029-4c6d-ae21-6ee0a7a8e243"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 53, 1, 938, DateTimeKind.Local).AddTicks(9477), new DateTime(2020, 6, 24, 18, 53, 1, 938, DateTimeKind.Local).AddTicks(9469), new DateTime(2020, 6, 24, 18, 53, 1, 938, DateTimeKind.Local).AddTicks(9453), new DateTime(2020, 6, 24, 18, 53, 1, 938, DateTimeKind.Local).AddTicks(9483) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 53, 1, 937, DateTimeKind.Local).AddTicks(3158), new DateTime(2020, 6, 24, 18, 53, 1, 937, DateTimeKind.Local).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 53, 1, 937, DateTimeKind.Local).AddTicks(1418), new DateTime(2020, 6, 24, 18, 53, 1, 937, DateTimeKind.Local).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 53, 1, 937, DateTimeKind.Local).AddTicks(3115), new DateTime(2020, 6, 24, 18, 53, 1, 937, DateTimeKind.Local).AddTicks(3133) });
        }
    }
}
