using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Quanda.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "Created", "Edited", "QuestionText", "QuestionTitle" },
                values: new object[] { 1, new DateTime(2020, 4, 27, 15, 10, 15, 849, DateTimeKind.Local).AddTicks(353), new DateTime(2020, 4, 27, 15, 10, 15, 850, DateTimeKind.Local).AddTicks(8735), "About First Question", "First Question" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "Created", "Edited", "QuestionText", "QuestionTitle" },
                values: new object[] { 2, new DateTime(2020, 4, 27, 15, 10, 15, 850, DateTimeKind.Local).AddTicks(9171), new DateTime(2020, 4, 27, 15, 10, 15, 850, DateTimeKind.Local).AddTicks(9192), "About Second Question", "Second Question" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 2);
        }
    }
}
