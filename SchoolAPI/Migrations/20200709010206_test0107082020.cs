using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class test0107082020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseManagements_Courses_CoursesId",
                table: "CourseManagements");

            migrationBuilder.DropIndex(
                name: "IX_CourseManagements_CoursesId",
                table: "CourseManagements");

            migrationBuilder.DropColumn(
                name: "CoursesId",
                table: "CourseManagements");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CoursesId",
                table: "CourseManagements",
                type: "uniqueidentifier",
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
                name: "IX_CourseManagements_CoursesId",
                table: "CourseManagements",
                column: "CoursesId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseManagements_Courses_CoursesId",
                table: "CourseManagements",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
