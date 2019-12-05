using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GymAssignment.Data.Migrations
{
    public partial class IdentityRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FavouriteLocation",
                table: "AspNetUsers");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FavouriteLocation",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
