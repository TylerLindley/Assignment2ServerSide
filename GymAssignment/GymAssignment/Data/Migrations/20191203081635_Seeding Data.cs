using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GymAssignment.Data.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(nullable: false),
                    PhysicalActivity = table.Column<string>(nullable: false),
                    Time = table.Column<string>(nullable: false),
                    Instructor = table.Column<string>(nullable: false),
                    Location = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FacultyList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Shift = table.Column<string>(nullable: false),
                    Position = table.Column<string>(nullable: false),
                    Department = table.Column<string>(nullable: false),
                    StoreLocation = table.Column<string>(nullable: false),
                    HomeAddress = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacultyList", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CourseList",
                columns: new[] { "Id", "CourseName", "Instructor", "Location", "PhysicalActivity", "Time" },
                values: new object[,]
                {
                    { 20, "Fitness Junkie 101", "Tyler Lindley", "Bayfield", "Dance", "Every Tuesday from 9-12pm" },
                    { 21, "Synchronized Swimming", "Justin Hunt", "Mapleton", "Swimming", "Alternating Thursday's from 5-10pm" },
                    { 22, "Pushup Practice", "Alyssa Edwards", "Allandale", "Muscle Gain", "Everyday from 2-4pm" },
                    { 23, "Monkeybar Cross", "Tyler Lindley", "Bayfield", "Climbing", "Every third Monday from 12-10pm" }
                });

            migrationBuilder.InsertData(
                table: "FacultyList",
                columns: new[] { "Id", "Department", "HomeAddress", "Name", "PhoneNumber", "Position", "Shift", "StoreLocation" },
                values: new object[,]
                {
                    { 18, "Security", "8 Barton Street", "John Johnson", "289-652-0551", "On Call Guard", "Nights", "Bayfield" },
                    { 17, "Security", "19 Little Avenue", "Jim Smith", "289-310-0232", "Security Manager", "Nights", "Bayfield" },
                    { 16, "Fitness Trainer", "6 Essa Road", "Alyssa Edwards", "289-867-5309", "Dance Teacher", "Days", "Allandale" },
                    { 15, "Fitness Trainer", "42 Mapleton Avenue", "Justin Hunt", "289-921-0193", "Zuumba", "Nights", "Mapleton" },
                    { 19, "Reception", "941 Mapleview East", "Abel Daughtry", "289-323-5410", "Front Desk", "Days", "Allandale" },
                    { 13, "Management", "94 Duckworth Street", "Kyle Scagnetti", "289-923-1242", "Lead Days Manager", "Days", "Allandale" },
                    { 12, "Management", "152 Bayfield Street", "Mason Ferrie", "289-525-1232", "Assistant Store Manager", "Nights", "Bayfield" },
                    { 11, "Management", "113 St. Vincent Street", "Tyler Lindley", "289-600-0244", "Store Manager", "Nights", "Bayfield" },
                    { 14, "Management", "14 Grove Street", "Danil Borisov", "289-912-4129", "Assistant Days Manager", "Days", "Mapleton" }
                });

            migrationBuilder.InsertData(
                table: "TimeOffSchedule",
                columns: new[] { "Id", "CoveredBy", "Date", "Name", "PostTime" },
                values: new object[,]
                {
                    { 24, "Mason", "January 1st to February 4th", "Tyler Lindley", new DateTime(2019, 12, 3, 3, 16, 35, 315, DateTimeKind.Local).AddTicks(5013) },
                    { 25, "Mason", "January 1st to February 4th", "Kyle Scagnetti", new DateTime(2019, 12, 3, 3, 16, 35, 319, DateTimeKind.Local).AddTicks(108) },
                    { 26, "Tyler", "Februay 24th to February 29th", "Justin Hunt", new DateTime(2019, 12, 3, 3, 16, 35, 319, DateTimeKind.Local).AddTicks(146) },
                    { 27, "Tyler", "Februay 24th to February 29th", "Mason Ferrie", new DateTime(2019, 12, 3, 3, 16, 35, 319, DateTimeKind.Local).AddTicks(155) }
                });

            migrationBuilder.InsertData(
                table: "UsersTable",
                columns: new[] { "Id", "Address", "GoalWeight", "Location", "Name", "PhoneNumber", "PreferredTraining", "StartingWeight" },
                values: new object[,]
                {
                    { 8, "19 Little Avenue", 185m, "Bayfield", "Austin Newnez", "289-310-0232", "Dancing", 174m },
                    { 7, "6 Essa Road", 197m, "Allandale", "Jake Smith", "289-867-5309", "Jump-Rope", 182m },
                    { 5, "42 Mapleton Avenue", 164m, "Mapleton", "Justin Hunt", "289-921-0193", "Walking", 195m },
                    { 1, "113 St. Vincent Street", 150m, "Bayfield", "Tyler Lindley", "289-600-0244", "Swimming", 152m },
                    { 3, "94 Duckworth Street", 165m, "Allandale", "Kyle Scagnetti", "289-923-1242", "Running", 168m },
                    { 2, "152 Bayfield Street", 169m, "Bayfield", "Mason Ferrie", "289-523-1232", "Rock Climbing", 185m },
                    { 9, "8 Barton Street", 200m, "Bayfield", "Nathan Jorje", "289-652-0551", "Gymnastics", 147m },
                    { 4, "14 Grove Street", 152m, "Mapleton", "Danil Borisov", "289-912-4129", "Long Distance Sprint", 184m },
                    { 10, "941 Mapleview East", 185m, "Allandale", "Cindy Ackinson", "289-323-5410", "Speed Walking", 135m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseList");

            migrationBuilder.DropTable(
                name: "FacultyList");

            migrationBuilder.DeleteData(
                table: "TimeOffSchedule",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TimeOffSchedule",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TimeOffSchedule",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TimeOffSchedule",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "UsersTable",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UsersTable",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UsersTable",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UsersTable",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UsersTable",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UsersTable",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UsersTable",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UsersTable",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UsersTable",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
