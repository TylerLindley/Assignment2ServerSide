using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GymAssignment.Data.Migrations
{
    public partial class ImplementRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TimeOffSchedule",
                keyColumn: "Id",
                keyValue: 24,
                column: "PostTime",
                value: new DateTime(2019, 12, 4, 10, 39, 6, 400, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "TimeOffSchedule",
                keyColumn: "Id",
                keyValue: 25,
                column: "PostTime",
                value: new DateTime(2019, 12, 4, 10, 39, 6, 404, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "TimeOffSchedule",
                keyColumn: "Id",
                keyValue: 26,
                column: "PostTime",
                value: new DateTime(2019, 12, 4, 10, 39, 6, 404, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "TimeOffSchedule",
                keyColumn: "Id",
                keyValue: 27,
                column: "PostTime",
                value: new DateTime(2019, 12, 4, 10, 39, 6, 404, DateTimeKind.Local).AddTicks(458));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TimeOffSchedule",
                keyColumn: "Id",
                keyValue: 24,
                column: "PostTime",
                value: new DateTime(2019, 12, 4, 10, 11, 47, 8, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "TimeOffSchedule",
                keyColumn: "Id",
                keyValue: 25,
                column: "PostTime",
                value: new DateTime(2019, 12, 4, 10, 11, 47, 11, DateTimeKind.Local).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "TimeOffSchedule",
                keyColumn: "Id",
                keyValue: 26,
                column: "PostTime",
                value: new DateTime(2019, 12, 4, 10, 11, 47, 11, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "TimeOffSchedule",
                keyColumn: "Id",
                keyValue: 27,
                column: "PostTime",
                value: new DateTime(2019, 12, 4, 10, 11, 47, 11, DateTimeKind.Local).AddTicks(7775));
        }
    }
}
