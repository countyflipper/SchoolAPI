using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class p : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseSection_SectionAssigns_SectionAssignId",
                table: "CourseSection");

            migrationBuilder.DropIndex(
                name: "IX_CourseSection_SectionAssignId",
                table: "CourseSection");

            migrationBuilder.DropColumn(
                name: "SectionAssignId",
                table: "CourseSection");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SectionAssignId",
                table: "CourseSection",
                type: "uniqueidentifier",
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
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 50, 5, 622, DateTimeKind.Local).AddTicks(3672), new DateTime(2020, 6, 24, 18, 50, 5, 622, DateTimeKind.Local).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("a884663b-f3c7-46da-a541-9cef2ff12d66"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 50, 5, 622, DateTimeKind.Local).AddTicks(5429), new DateTime(2020, 6, 24, 18, 50, 5, 622, DateTimeKind.Local).AddTicks(5449) });

            migrationBuilder.UpdateData(
                table: "SectionAssigns",
                keyColumn: "SectionAssignID",
                keyValue: new Guid("df38bdf1-c93b-43e6-9ed1-0da79d774967"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 6, 24, 18, 50, 5, 622, DateTimeKind.Local).AddTicks(5475), new DateTime(2020, 6, 24, 18, 50, 5, 622, DateTimeKind.Local).AddTicks(5477) });

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
        }
    }
}
