using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GymAssignment.Data.Migrations
{
    public partial class AddingRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FavouriteLocation",
                table: "AspNetUsers",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FavouriteLocation",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "TimeOffSchedule",
                keyColumn: "Id",
                keyValue: 24,
                column: "PostTime",
                value: new DateTime(2019, 12, 3, 3, 16, 35, 315, DateTimeKind.Local).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "TimeOffSchedule",
                keyColumn: "Id",
                keyValue: 25,
                column: "PostTime",
                value: new DateTime(2019, 12, 3, 3, 16, 35, 319, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "TimeOffSchedule",
                keyColumn: "Id",
                keyValue: 26,
                column: "PostTime",
                value: new DateTime(2019, 12, 3, 3, 16, 35, 319, DateTimeKind.Local).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "TimeOffSchedule",
                keyColumn: "Id",
                keyValue: 27,
                column: "PostTime",
                value: new DateTime(2019, 12, 3, 3, 16, 35, 319, DateTimeKind.Local).AddTicks(155));
        }
    }
}
