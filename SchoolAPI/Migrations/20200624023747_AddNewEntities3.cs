using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class AddNewEntities3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SectionAssignId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SectionAssignId",
                table: "CourseSection",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SectionAssigns",
                columns: table => new
                {
                    SectionAssignID = table.Column<Guid>(nullable: false),
                    SubmissionText = table.Column<string>(maxLength: 60, nullable: false),
                    Score = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionAssigns", x => x.SectionAssignID);
                });

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

            migrationBuilder.InsertData(
                table: "SectionAssigns",
                columns: new[] { "SectionAssignID", "CreatedDate", "Score", "SubmissionText", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("4fb597ea-72aa-4ddf-8d06-f009ad8a2d3a"), new DateTime(2020, 6, 23, 22, 37, 46, 878, DateTimeKind.Local).AddTicks(6490), 91, "Please see link to assignment.", new DateTime(2020, 6, 23, 22, 37, 46, 878, DateTimeKind.Local).AddTicks(6896) },
                    { new Guid("a884663b-f3c7-46da-a541-9cef2ff12d66"), new DateTime(2020, 6, 23, 22, 37, 46, 878, DateTimeKind.Local).AddTicks(7315), 84, "Please see link to assignment.", new DateTime(2020, 6, 23, 22, 37, 46, 878, DateTimeKind.Local).AddTicks(7333) },
                    { new Guid("df38bdf1-c93b-43e6-9ed1-0da79d774967"), new DateTime(2020, 6, 23, 22, 37, 46, 878, DateTimeKind.Local).AddTicks(7343), 99, "Please see link to assignment.", new DateTime(2020, 6, 23, 22, 37, 46, 878, DateTimeKind.Local).AddTicks(7345) }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Users_SectionAssignId",
                table: "Users",
                column: "SectionAssignId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSection_SectionAssignId",
                table: "CourseSection",
                column: "SectionAssignId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseSection_SectionAssigns_SectionAssignId",
                table: "CourseSection",
                column: "SectionAssignId",
                principalTable: "SectionAssigns",
                principalColumn: "SectionAssignID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_SectionAssigns_SectionAssignId",
                table: "Users",
                column: "SectionAssignId",
                principalTable: "SectionAssigns",
                principalColumn: "SectionAssignID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseSection_SectionAssigns_SectionAssignId",
                table: "CourseSection");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_SectionAssigns_SectionAssignId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "SectionAssigns");

            migrationBuilder.DropIndex(
                name: "IX_Users_SectionAssignId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_CourseSection_SectionAssignId",
                table: "CourseSection");

            migrationBuilder.DropColumn(
                name: "SectionAssignId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SectionAssignId",
                table: "CourseSection");

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 26, 49, 766, DateTimeKind.Local).AddTicks(5174), new DateTime(2020, 6, 23, 22, 26, 49, 766, DateTimeKind.Local).AddTicks(5172), new DateTime(2020, 6, 23, 22, 26, 49, 766, DateTimeKind.Local).AddTicks(5170), new DateTime(2020, 6, 23, 22, 26, 49, 766, DateTimeKind.Local).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2447"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 26, 49, 766, DateTimeKind.Local).AddTicks(3564), new DateTime(2020, 6, 23, 22, 26, 49, 766, DateTimeKind.Local).AddTicks(2932), new DateTime(2020, 6, 23, 22, 26, 49, 766, DateTimeKind.Local).AddTicks(1815), new DateTime(2020, 6, 23, 22, 26, 49, 766, DateTimeKind.Local).AddTicks(4093) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e04"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 26, 49, 766, DateTimeKind.Local).AddTicks(5149), new DateTime(2020, 6, 23, 22, 26, 49, 766, DateTimeKind.Local).AddTicks(5140), new DateTime(2020, 6, 23, 22, 26, 49, 766, DateTimeKind.Local).AddTicks(5116), new DateTime(2020, 6, 23, 22, 26, 49, 766, DateTimeKind.Local).AddTicks(5158) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 26, 49, 765, DateTimeKind.Local).AddTicks(6017), new DateTime(2020, 6, 23, 22, 26, 49, 765, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 26, 49, 765, DateTimeKind.Local).AddTicks(4542), new DateTime(2020, 6, 23, 22, 26, 49, 765, DateTimeKind.Local).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 26, 49, 765, DateTimeKind.Local).AddTicks(5971), new DateTime(2020, 6, 23, 22, 26, 49, 765, DateTimeKind.Local).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("3f6e887a-40f1-4032-a347-5c526d7ca36d"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(2775), new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(2227), new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(1305), new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("a6a002f5-7d7b-4a3c-977b-cd78f55252bf"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(3831), new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(3829), new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(3827), new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(3833) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("b880cf73-b029-4c6d-ae21-6ee0a7a8e243"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(3811), new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(3804), new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(3787), new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(3818) });
        }
    }
}
