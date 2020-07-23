using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class tst07172020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "CourseName",
                table: "Courses",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CourseManagements",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AssignmentTitle",
                table: "CourseManagements",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(553), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(551), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(549), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2447"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 843, DateTimeKind.Local).AddTicks(9268), new DateTime(2020, 7, 17, 19, 39, 59, 843, DateTimeKind.Local).AddTicks(8833), new DateTime(2020, 7, 17, 19, 39, 59, 843, DateTimeKind.Local).AddTicks(8033), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e04"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(529), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(520), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(481), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 843, DateTimeKind.Local).AddTicks(4029), new DateTime(2020, 7, 17, 19, 39, 59, 843, DateTimeKind.Local).AddTicks(4031) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 843, DateTimeKind.Local).AddTicks(3176), new DateTime(2020, 7, 17, 19, 39, 59, 843, DateTimeKind.Local).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 843, DateTimeKind.Local).AddTicks(4002), new DateTime(2020, 7, 17, 19, 39, 59, 843, DateTimeKind.Local).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("4fb597ea-72aa-4ddf-8d06-f009ad8a2d3a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 845, DateTimeKind.Local).AddTicks(3245), new DateTime(2020, 7, 17, 19, 39, 59, 845, DateTimeKind.Local).AddTicks(3874) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("a884663b-f3c7-46da-a541-9cef2ff12d66"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 845, DateTimeKind.Local).AddTicks(5400), new DateTime(2020, 7, 17, 19, 39, 59, 845, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("df38bdf1-c93b-43e6-9ed1-0da79d774967"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 845, DateTimeKind.Local).AddTicks(5441), new DateTime(2020, 7, 17, 19, 39, 59, 845, DateTimeKind.Local).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("3f6e887a-40f1-4032-a347-5c526d7ca36d"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(5203), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(4807), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(4373), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("a6a002f5-7d7b-4a3c-977b-cd78f55252bf"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(6088), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(6086), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(6084), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("b880cf73-b029-4c6d-ae21-6ee0a7a8e243"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(6068), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(6061), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(6044), new DateTime(2020, 7, 17, 19, 39, 59, 844, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate", "age" },
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 842, DateTimeKind.Local).AddTicks(8352), new DateTime(2020, 7, 17, 19, 39, 59, 842, DateTimeKind.Local).AddTicks(8354), 48 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                columns: new[] { "CreatedDate", "UpdatedDate", "age" },
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 842, DateTimeKind.Local).AddTicks(6019), new DateTime(2020, 7, 17, 19, 39, 59, 842, DateTimeKind.Local).AddTicks(6622), 34 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                columns: new[] { "CreatedDate", "UpdatedDate", "age" },
                values: new object[] { new DateTime(2020, 7, 17, 19, 39, 59, 842, DateTimeKind.Local).AddTicks(8297), new DateTime(2020, 7, 17, 19, 39, 59, 842, DateTimeKind.Local).AddTicks(8314), 24 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "age",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "CourseName",
                table: "Courses",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CourseManagements",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "AssignmentTitle",
                table: "CourseManagements",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 8, 21, 2, 6, 308, DateTimeKind.Local).AddTicks(8069), new DateTime(2020, 7, 8, 21, 2, 6, 308, DateTimeKind.Local).AddTicks(8067), new DateTime(2020, 7, 8, 21, 2, 6, 308, DateTimeKind.Local).AddTicks(8065), new DateTime(2020, 7, 8, 21, 2, 6, 308, DateTimeKind.Local).AddTicks(8071) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2447"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 8, 21, 2, 6, 308, DateTimeKind.Local).AddTicks(7277), new DateTime(2020, 7, 8, 21, 2, 6, 308, DateTimeKind.Local).AddTicks(6904), new DateTime(2020, 7, 8, 21, 2, 6, 308, DateTimeKind.Local).AddTicks(6491), new DateTime(2020, 7, 8, 21, 2, 6, 308, DateTimeKind.Local).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e04"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 8, 21, 2, 6, 308, DateTimeKind.Local).AddTicks(8048), new DateTime(2020, 7, 8, 21, 2, 6, 308, DateTimeKind.Local).AddTicks(8032), new DateTime(2020, 7, 8, 21, 2, 6, 308, DateTimeKind.Local).AddTicks(8017), new DateTime(2020, 7, 8, 21, 2, 6, 308, DateTimeKind.Local).AddTicks(8055) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 8, 21, 2, 6, 308, DateTimeKind.Local).AddTicks(2488), new DateTime(2020, 7, 8, 21, 2, 6, 308, DateTimeKind.Local).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 8, 21, 2, 6, 308, DateTimeKind.Local).AddTicks(1668), new DateTime(2020, 7, 8, 21, 2, 6, 308, DateTimeKind.Local).AddTicks(2057) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 8, 21, 2, 6, 308, DateTimeKind.Local).AddTicks(2463), new DateTime(2020, 7, 8, 21, 2, 6, 308, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("4fb597ea-72aa-4ddf-8d06-f009ad8a2d3a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 8, 21, 2, 6, 309, DateTimeKind.Local).AddTicks(8539), new DateTime(2020, 7, 8, 21, 2, 6, 309, DateTimeKind.Local).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("a884663b-f3c7-46da-a541-9cef2ff12d66"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 8, 21, 2, 6, 310, DateTimeKind.Local).AddTicks(143), new DateTime(2020, 7, 8, 21, 2, 6, 310, DateTimeKind.Local).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("df38bdf1-c93b-43e6-9ed1-0da79d774967"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 8, 21, 2, 6, 310, DateTimeKind.Local).AddTicks(186), new DateTime(2020, 7, 8, 21, 2, 6, 310, DateTimeKind.Local).AddTicks(188) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("3f6e887a-40f1-4032-a347-5c526d7ca36d"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 8, 21, 2, 6, 309, DateTimeKind.Local).AddTicks(2511), new DateTime(2020, 7, 8, 21, 2, 6, 309, DateTimeKind.Local).AddTicks(2137), new DateTime(2020, 7, 8, 21, 2, 6, 309, DateTimeKind.Local).AddTicks(1725), new DateTime(2020, 7, 8, 21, 2, 6, 309, DateTimeKind.Local).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("a6a002f5-7d7b-4a3c-977b-cd78f55252bf"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 8, 21, 2, 6, 309, DateTimeKind.Local).AddTicks(3342), new DateTime(2020, 7, 8, 21, 2, 6, 309, DateTimeKind.Local).AddTicks(3340), new DateTime(2020, 7, 8, 21, 2, 6, 309, DateTimeKind.Local).AddTicks(3338), new DateTime(2020, 7, 8, 21, 2, 6, 309, DateTimeKind.Local).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("b880cf73-b029-4c6d-ae21-6ee0a7a8e243"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 8, 21, 2, 6, 309, DateTimeKind.Local).AddTicks(3322), new DateTime(2020, 7, 8, 21, 2, 6, 309, DateTimeKind.Local).AddTicks(3315), new DateTime(2020, 7, 8, 21, 2, 6, 309, DateTimeKind.Local).AddTicks(3300), new DateTime(2020, 7, 8, 21, 2, 6, 309, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 8, 21, 2, 6, 307, DateTimeKind.Local).AddTicks(7383), new DateTime(2020, 7, 8, 21, 2, 6, 307, DateTimeKind.Local).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 8, 21, 2, 6, 307, DateTimeKind.Local).AddTicks(5620), new DateTime(2020, 7, 8, 21, 2, 6, 307, DateTimeKind.Local).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 7, 8, 21, 2, 6, 307, DateTimeKind.Local).AddTicks(7336), new DateTime(2020, 7, 8, 21, 2, 6, 307, DateTimeKind.Local).AddTicks(7354) });
        }
    }
}
