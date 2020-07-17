using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class AddNewEntities6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CourseManagementId",
                table: "SectionAssigns",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CourseManagementId",
                table: "Courses",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CourseManagements",
                columns: table => new
                {
                    CourseManagementID = table.Column<Guid>(nullable: false),
                    AssignmentTitle = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseManagements", x => x.CourseManagementID);
                });

            migrationBuilder.InsertData(
                table: "CourseManagements",
                columns: new[] { "CourseManagementID", "AssignmentTitle", "Description" },
                values: new object[,]
                {
                    { new Guid("c769e19d-c895-4ad0-97dc-9b497bff0d3e"), "GitHub Tutorial.", "Learn the basic of GitHub." },
                    { new Guid("c47748fb-1fa7-4745-a863-78fa91633c93"), "Calculator", "Build a calculator using the basic math." },
                    { new Guid("a12001ac-75cd-43ad-916f-79e1a8cd40f1"), "Statistic Application", "Build an app that includes basic math and statistics." }
                });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(773), new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(771), new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(769), new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2447"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 56, 44, 633, DateTimeKind.Local).AddTicks(9875), new DateTime(2020, 6, 23, 22, 56, 44, 633, DateTimeKind.Local).AddTicks(9478), new DateTime(2020, 6, 23, 22, 56, 44, 633, DateTimeKind.Local).AddTicks(9045), new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e04"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(752), new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(745), new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(730), new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(759) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 56, 44, 633, DateTimeKind.Local).AddTicks(5253), new DateTime(2020, 6, 23, 22, 56, 44, 633, DateTimeKind.Local).AddTicks(5255) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 56, 44, 633, DateTimeKind.Local).AddTicks(4378), new DateTime(2020, 6, 23, 22, 56, 44, 633, DateTimeKind.Local).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 56, 44, 633, DateTimeKind.Local).AddTicks(5220), new DateTime(2020, 6, 23, 22, 56, 44, 633, DateTimeKind.Local).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("4fb597ea-72aa-4ddf-8d06-f009ad8a2d3a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 56, 44, 635, DateTimeKind.Local).AddTicks(1119), new DateTime(2020, 6, 23, 22, 56, 44, 635, DateTimeKind.Local).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("a884663b-f3c7-46da-a541-9cef2ff12d66"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 56, 44, 635, DateTimeKind.Local).AddTicks(1964), new DateTime(2020, 6, 23, 22, 56, 44, 635, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("df38bdf1-c93b-43e6-9ed1-0da79d774967"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 56, 44, 635, DateTimeKind.Local).AddTicks(1990), new DateTime(2020, 6, 23, 22, 56, 44, 635, DateTimeKind.Local).AddTicks(1991) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("3f6e887a-40f1-4032-a347-5c526d7ca36d"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(5669), new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(5269), new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(4833), new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("a6a002f5-7d7b-4a3c-977b-cd78f55252bf"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(6500), new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(6498), new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(6496), new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(6502) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("b880cf73-b029-4c6d-ae21-6ee0a7a8e243"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(6481), new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(6474), new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(6459), new DateTime(2020, 6, 23, 22, 56, 44, 634, DateTimeKind.Local).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 56, 44, 632, DateTimeKind.Local).AddTicks(9786), new DateTime(2020, 6, 23, 22, 56, 44, 632, DateTimeKind.Local).AddTicks(9789) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 56, 44, 632, DateTimeKind.Local).AddTicks(8034), new DateTime(2020, 6, 23, 22, 56, 44, 632, DateTimeKind.Local).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 56, 44, 632, DateTimeKind.Local).AddTicks(9741), new DateTime(2020, 6, 23, 22, 56, 44, 632, DateTimeKind.Local).AddTicks(9759) });

            migrationBuilder.CreateIndex(
                name: "IX_SectionAssigns_CourseManagementId",
                table: "SectionAssigns",
                column: "CourseManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseManagementId",
                table: "Courses",
                column: "CourseManagementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseManagements_CourseManagementId",
                table: "Courses",
                column: "CourseManagementId",
                principalTable: "CourseManagements",
                principalColumn: "CourseManagementID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionAssigns_CourseManagements_CourseManagementId",
                table: "SectionAssigns",
                column: "CourseManagementId",
                principalTable: "CourseManagements",
                principalColumn: "CourseManagementID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseManagements_CourseManagementId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionAssigns_CourseManagements_CourseManagementId",
                table: "SectionAssigns");

            migrationBuilder.DropTable(
                name: "CourseManagements");

            migrationBuilder.DropIndex(
                name: "IX_SectionAssigns_CourseManagementId",
                table: "SectionAssigns");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseManagementId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseManagementId",
                table: "SectionAssigns");

            migrationBuilder.DropColumn(
                name: "CourseManagementId",
                table: "Courses");

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
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 53, 58, 763, DateTimeKind.Local).AddTicks(6847), new DateTime(2020, 6, 23, 22, 53, 58, 763, DateTimeKind.Local).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 53, 58, 763, DateTimeKind.Local).AddTicks(4588), new DateTime(2020, 6, 23, 22, 53, 58, 763, DateTimeKind.Local).AddTicks(5216) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 53, 58, 763, DateTimeKind.Local).AddTicks(6779), new DateTime(2020, 6, 23, 22, 53, 58, 763, DateTimeKind.Local).AddTicks(6799) });
        }
    }
}
