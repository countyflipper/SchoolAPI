using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class AddNewEntities2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SectionEnrollManageId",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SectionEnrollManages",
                columns: table => new
                {
                    SectionEnrollID = table.Column<Guid>(nullable: false),
                    StartDate = table.Column<DateTime>(maxLength: 60, nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionEnrollManages", x => x.SectionEnrollID);
                });

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

            migrationBuilder.InsertData(
                table: "SectionEnrollManages",
                columns: new[] { "SectionEnrollID", "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("3f6e887a-40f1-4032-a347-5c526d7ca36d"), new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(2775), new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(2227), new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(1305), new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(3337) },
                    { new Guid("b880cf73-b029-4c6d-ae21-6ee0a7a8e243"), new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(3811), new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(3804), new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(3787), new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(3818) },
                    { new Guid("a6a002f5-7d7b-4a3c-977b-cd78f55252bf"), new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(3831), new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(3829), new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(3827), new DateTime(2020, 6, 23, 22, 26, 49, 767, DateTimeKind.Local).AddTicks(3833) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_SectionEnrollManageId",
                table: "Users",
                column: "SectionEnrollManageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_SectionEnrollManages_SectionEnrollManageId",
                table: "Users",
                column: "SectionEnrollManageId",
                principalTable: "SectionEnrollManages",
                principalColumn: "SectionEnrollID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_SectionEnrollManages_SectionEnrollManageId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "SectionEnrollManages");

            migrationBuilder.DropIndex(
                name: "IX_Users_SectionEnrollManageId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SectionEnrollManageId",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(8195), new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(8194), new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(8192), new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(8197) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2447"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(7370), new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(6973), new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(6533), new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e04"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(8176), new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(8166), new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(8149), new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(8182) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(2704), new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(2706) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(1782), new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(2672), new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(2694) });
        }
    }
}
