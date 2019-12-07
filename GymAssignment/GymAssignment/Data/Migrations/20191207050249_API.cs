using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GymAssignment.Data.Migrations
{
    public partial class API : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TimeOffSchedule",
                keyColumn: "Id",
                keyValue: 24,
                column: "PostTime",
                value: new DateTime(2019, 12, 7, 0, 2, 48, 899, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "TimeOffSchedule",
                keyColumn: "Id",
                keyValue: 25,
                column: "PostTime",
                value: new DateTime(2019, 12, 7, 0, 2, 48, 904, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "TimeOffSchedule",
                keyColumn: "Id",
                keyValue: 26,
                column: "PostTime",
                value: new DateTime(2019, 12, 7, 0, 2, 48, 904, DateTimeKind.Local).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "TimeOffSchedule",
                keyColumn: "Id",
                keyValue: 27,
                column: "PostTime",
                value: new DateTime(2019, 12, 7, 0, 2, 48, 904, DateTimeKind.Local).AddTicks(6342));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TimeOffSchedule",
                keyColumn: "Id",
                keyValue: 24,
                column: "PostTime",
                value: new DateTime(2019, 12, 4, 10, 55, 24, 330, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "TimeOffSchedule",
                keyColumn: "Id",
                keyValue: 25,
                column: "PostTime",
                value: new DateTime(2019, 12, 4, 10, 55, 24, 334, DateTimeKind.Local).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "TimeOffSchedule",
                keyColumn: "Id",
                keyValue: 26,
                column: "PostTime",
                value: new DateTime(2019, 12, 4, 10, 55, 24, 334, DateTimeKind.Local).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "TimeOffSchedule",
                keyColumn: "Id",
                keyValue: 27,
                column: "PostTime",
                value: new DateTime(2019, 12, 4, 10, 55, 24, 334, DateTimeKind.Local).AddTicks(1511));
        }
    }
}
