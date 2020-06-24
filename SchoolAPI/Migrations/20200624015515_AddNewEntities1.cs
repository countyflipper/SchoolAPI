using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class AddNewEntities1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CourseSectionId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Courses",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Courses",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "CourseSection",
                columns: table => new
                {
                    CourseSectionID = table.Column<Guid>(nullable: false),
                    StartDate = table.Column<DateTime>(maxLength: 60, nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSection", x => x.CourseSectionID);
                });

            migrationBuilder.InsertData(
                table: "CourseSection",
                columns: new[] { "CourseSectionID", "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2447"), new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(7370), new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(6973), new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(6533), new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(7752) },
                    { new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e04"), new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(8176), new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(8166), new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(8149), new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(8182) },
                    { new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"), new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(8195), new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(8194), new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(8192), new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(8197) }
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(2704), "Students will obtain a conceptual foundation of database design and explore the implications for organizational database usage.", new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(2706) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(1782), "Learn version control and apply the concepts to building an API using Python, Docker, and Pycharm. ", new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(2672), "Learn how to build an ASP .NET Web using C# and github.", new DateTime(2020, 6, 23, 21, 55, 14, 674, DateTimeKind.Local).AddTicks(2694) });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CourseSectionId",
                table: "Users",
                column: "CourseSectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_CourseSection_CourseSectionId",
                table: "Users",
                column: "CourseSectionId",
                principalTable: "CourseSection",
                principalColumn: "CourseSectionID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_CourseSection_CourseSectionId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "CourseSection");

            migrationBuilder.DropIndex(
                name: "IX_Users_CourseSectionId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CourseSectionId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Courses");
        }
    }
}
