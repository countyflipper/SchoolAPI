using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class AddNewData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseManagements_CourseManagementId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionAssigns_CourseManagements_CourseManagementId",
                table: "SectionAssigns");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_SectionAssigns_SectionAssignId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_SectionAssignId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_SectionAssigns_CourseManagementId",
                table: "SectionAssigns");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseManagementId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "SectionAssignId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CourseManagementId",
                table: "SectionAssigns");

            migrationBuilder.DropColumn(
                name: "CourseManagementId",
                table: "Courses");

            migrationBuilder.AddColumn<string>(
                name: "AssignID",
                table: "SectionAssigns",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsersID",
                table: "SectionAssigns",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssigmentID",
                table: "CourseManagements",
                maxLength: 60,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "CoursesId",
                table: "CourseManagements",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479813"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 50, 5, 621, DateTimeKind.Local).AddTicks(2235), new DateTime(2020, 6, 24, 18, 50, 5, 621, DateTimeKind.Local).AddTicks(2233), new DateTime(2020, 6, 24, 18, 50, 5, 621, DateTimeKind.Local).AddTicks(2231), new DateTime(2020, 6, 24, 18, 50, 5, 621, DateTimeKind.Local).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2447"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 50, 5, 621, DateTimeKind.Local).AddTicks(1276), new DateTime(2020, 6, 24, 18, 50, 5, 621, DateTimeKind.Local).AddTicks(816), new DateTime(2020, 6, 24, 18, 50, 5, 621, DateTimeKind.Local).AddTicks(286), new DateTime(2020, 6, 24, 18, 50, 5, 621, DateTimeKind.Local).AddTicks(1713) });

            migrationBuilder.UpdateData(
                table: "CourseSection",
                keyColumn: "CourseSectionID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e04"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 50, 5, 621, DateTimeKind.Local).AddTicks(2213), new DateTime(2020, 6, 24, 18, 50, 5, 621, DateTimeKind.Local).AddTicks(2206), new DateTime(2020, 6, 24, 18, 50, 5, 621, DateTimeKind.Local).AddTicks(2188), new DateTime(2020, 6, 24, 18, 50, 5, 621, DateTimeKind.Local).AddTicks(2221) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 50, 5, 620, DateTimeKind.Local).AddTicks(6003), new DateTime(2020, 6, 24, 18, 50, 5, 620, DateTimeKind.Local).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("6b172b1b-f32d-4dfd-be2f-0a6c56bc2446"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 50, 5, 620, DateTimeKind.Local).AddTicks(5020), new DateTime(2020, 6, 24, 18, 50, 5, 620, DateTimeKind.Local).AddTicks(5486) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: new Guid("7d31f5e1-bfb4-4e35-983d-d33269299e03"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 50, 5, 620, DateTimeKind.Local).AddTicks(5973), new DateTime(2020, 6, 24, 18, 50, 5, 620, DateTimeKind.Local).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("4fb597ea-72aa-4ddf-8d06-f009ad8a2d3a"),
                columns: new[] { "AssignID", "CreatedDate", "UpdatedDate", "UsersID" },
                values: new object[] { "C769E19D-C895-4AD0-97DC-9B497BFF0D3E", new DateTime(2020, 6, 24, 18, 50, 5, 622, DateTimeKind.Local).AddTicks(3672), new DateTime(2020, 6, 24, 18, 50, 5, 622, DateTimeKind.Local).AddTicks(4134), "80abbca8-664d-4b20-b5de-024705497d4a" });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("a884663b-f3c7-46da-a541-9cef2ff12d66"),
                columns: new[] { "AssignID", "CreatedDate", "UpdatedDate", "UsersID" },
                values: new object[] { "C769E19D-C895-4AD0-97DC-9B497BFF0D3E", new DateTime(2020, 6, 24, 18, 50, 5, 622, DateTimeKind.Local).AddTicks(5429), new DateTime(2020, 6, 24, 18, 50, 5, 622, DateTimeKind.Local).AddTicks(5449), "021ca3c1-0deb-4afd-ae94-2159a8479811" });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("df38bdf1-c93b-43e6-9ed1-0da79d774967"),
                columns: new[] { "AssignID", "CreatedDate", "UpdatedDate", "UsersID" },
                values: new object[] { "C769E19D-C895-4AD0-97DC-9B497BFF0D3E", new DateTime(2020, 6, 24, 18, 50, 5, 622, DateTimeKind.Local).AddTicks(5475), new DateTime(2020, 6, 24, 18, 50, 5, 622, DateTimeKind.Local).AddTicks(5477), "86dba8c0-d178-41e7-938c-ed49778fb52a" });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("3f6e887a-40f1-4032-a347-5c526d7ca36d"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 50, 5, 621, DateTimeKind.Local).AddTicks(7446), new DateTime(2020, 6, 24, 18, 50, 5, 621, DateTimeKind.Local).AddTicks(6982), new DateTime(2020, 6, 24, 18, 50, 5, 621, DateTimeKind.Local).AddTicks(6491), new DateTime(2020, 6, 24, 18, 50, 5, 621, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("a6a002f5-7d7b-4a3c-977b-cd78f55252bf"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 50, 5, 621, DateTimeKind.Local).AddTicks(8396), new DateTime(2020, 6, 24, 18, 50, 5, 621, DateTimeKind.Local).AddTicks(8394), new DateTime(2020, 6, 24, 18, 50, 5, 621, DateTimeKind.Local).AddTicks(8392), new DateTime(2020, 6, 24, 18, 50, 5, 621, DateTimeKind.Local).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "SectionEnrollManages",
                keyColumn: "SectionEnrollID",
                keyValue: new Guid("b880cf73-b029-4c6d-ae21-6ee0a7a8e243"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 50, 5, 621, DateTimeKind.Local).AddTicks(8372), new DateTime(2020, 6, 24, 18, 50, 5, 621, DateTimeKind.Local).AddTicks(8363), new DateTime(2020, 6, 24, 18, 50, 5, 621, DateTimeKind.Local).AddTicks(8345), new DateTime(2020, 6, 24, 18, 50, 5, 621, DateTimeKind.Local).AddTicks(8378) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 50, 5, 619, DateTimeKind.Local).AddTicks(9897), new DateTime(2020, 6, 24, 18, 50, 5, 619, DateTimeKind.Local).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 50, 5, 619, DateTimeKind.Local).AddTicks(7967), new DateTime(2020, 6, 24, 18, 50, 5, 619, DateTimeKind.Local).AddTicks(8466) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 50, 5, 619, DateTimeKind.Local).AddTicks(9847), new DateTime(2020, 6, 24, 18, 50, 5, 619, DateTimeKind.Local).AddTicks(9867) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseManagements_Courses_CoursesId",
                table: "CourseManagements");

            migrationBuilder.DropIndex(
                name: "IX_CourseManagements_CoursesId",
                table: "CourseManagements");

            migrationBuilder.DropColumn(
                name: "AssignID",
                table: "SectionAssigns");

            migrationBuilder.DropColumn(
                name: "UsersID",
                table: "SectionAssigns");

            migrationBuilder.DropColumn(
                name: "AssigmentID",
                table: "CourseManagements");

            migrationBuilder.DropColumn(
                name: "CoursesId",
                table: "CourseManagements");

            migrationBuilder.AddColumn<Guid>(
                name: "SectionAssignId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CourseManagementId",
                table: "SectionAssigns",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CourseManagementId",
                table: "Courses",
                type: "uniqueidentifier",
                nullable: true);

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
                name: "IX_Users_SectionAssignId",
                table: "Users",
                column: "SectionAssignId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Users_SectionAssigns_SectionAssignId",
                table: "Users",
                column: "SectionAssignId",
                principalTable: "SectionAssigns",
                principalColumn: "SectionAssignID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
