using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GymAssignment.Models;

namespace GymAssignment.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GymAssignment.Models.UsersTable> UsersTable { get; set; }
        public DbSet<GymAssignment.Models.TimeOffSchedule> TimeOffSchedule { get; set; }
        public DbSet<GymAssignment.Models.CourseList> CourseList { get; set; }
        public DbSet<GymAssignment.Models.FacultyList> FacultyList { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //putting information into our database
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UsersTable>().HasData(
                new Models.UsersTable() { Id = 1, Name = "Tyler Lindley", Address = "113 St. Vincent Street", GoalWeight = 150, StartingWeight = 152, Location = "Bayfield", PhoneNumber = "289-600-0244", PreferredTraining = "Swimming" },
                new Models.UsersTable() { Id = 2, Name = "Mason Ferrie", Address = "152 Bayfield Street", GoalWeight = 169, StartingWeight = 185, Location = "Bayfield", PhoneNumber = "289-523-1232", PreferredTraining = "Rock Climbing" },
                new Models.UsersTable() { Id = 3, Name = "Kyle Scagnetti", Address = "94 Duckworth Street", GoalWeight = 165, StartingWeight = 168, Location = "Allandale", PhoneNumber = "289-923-1242", PreferredTraining = "Running" },
                new Models.UsersTable() { Id = 4, Name = "Danil Borisov", Address = "14 Grove Street", GoalWeight = 152, StartingWeight = 184, Location = "Mapleton", PhoneNumber = "289-912-4129", PreferredTraining = "Long Distance Sprint" },
                new Models.UsersTable() { Id = 5, Name = "Justin Hunt", Address = "42 Mapleton Avenue", GoalWeight = 164, StartingWeight = 195, Location = "Mapleton", PhoneNumber = "289-921-0193", PreferredTraining = "Walking" },
                new Models.UsersTable() { Id = 7, Name = "Jake Smith", Address = "6 Essa Road", GoalWeight = 197, StartingWeight = 182, Location = "Allandale", PhoneNumber = "289-867-5309", PreferredTraining = "Jump-Rope" },
                new Models.UsersTable() { Id = 8, Name = "Austin Newnez", Address = "19 Little Avenue", GoalWeight = 185, StartingWeight = 174, Location = "Bayfield", PhoneNumber = "289-310-0232", PreferredTraining = "Dancing" },
                new Models.UsersTable() { Id = 9, Name = "Nathan Jorje", Address = "8 Barton Street", GoalWeight = 200, StartingWeight = 147, Location = "Bayfield", PhoneNumber = "289-652-0551", PreferredTraining = "Gymnastics" },
                new Models.UsersTable() { Id = 10, Name = "Cindy Ackinson", Address = "941 Mapleview East", GoalWeight = 185, StartingWeight = 135, Location = "Allandale", PhoneNumber = "289-323-5410", PreferredTraining = "Speed Walking" }
                );
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<FacultyList>().HasData(
                new Models.FacultyList() { Id = 11, Name = "Tyler Lindley", Department = "Management", HomeAddress = "113 St. Vincent Street", Position = "Store Manager", Shift = "Nights", PhoneNumber = "289-600-0244", StoreLocation = "Bayfield"},
                new Models.FacultyList() { Id = 12, Name = "Mason Ferrie", Department = "Management", HomeAddress = "152 Bayfield Street", Position = "Assistant Store Manager", Shift = "Nights", PhoneNumber = "289-525-1232", StoreLocation = "Bayfield"},
                new Models.FacultyList() { Id = 13, Name = "Kyle Scagnetti", Department = "Management", HomeAddress = "94 Duckworth Street",Position = "Lead Days Manager", Shift = "Days", PhoneNumber = "289-923-1242", StoreLocation = "Allandale"},
                new Models.FacultyList() { Id = 14, Name = "Danil Borisov", Department = "Management", HomeAddress= "14 Grove Street", Position = "Assistant Days Manager", Shift = "Days", PhoneNumber = "289-912-4129", StoreLocation = "Mapleton" },
                new Models.FacultyList() { Id = 15, Name = "Justin Hunt", Department = "Fitness Trainer", HomeAddress= "42 Mapleton Avenue", Position = "Zuumba", Shift = "Nights", PhoneNumber = "289-921-0193", StoreLocation = "Mapleton"},
                new Models.FacultyList() { Id = 16, Name = "Alyssa Edwards", Department = "Fitness Trainer", HomeAddress = "6 Essa Road", Position = "Dance Teacher", Shift = "Days", PhoneNumber = "289-867-5309", StoreLocation = "Allandale"},
                new Models.FacultyList() { Id = 17, Name = "Jim Smith", Department = "Security", HomeAddress = "19 Little Avenue", Position = "Security Manager", Shift = "Nights", PhoneNumber = "289-310-0232", StoreLocation = "Bayfield"},
                new Models.FacultyList() { Id = 18, Name = "John Johnson", Department = "Security", HomeAddress = "8 Barton Street", Position = "On Call Guard", Shift = "Nights", PhoneNumber = "289-652-0551", StoreLocation = "Bayfield"},
                new Models.FacultyList() { Id = 19, Name = "Abel Daughtry", Department = "Reception", HomeAddress = "941 Mapleview East", Position = "Front Desk", Shift = "Days", PhoneNumber = "289-323-5410", StoreLocation = "Allandale"}
                );
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CourseList>().HasData(
                new Models.CourseList() { Id = 20, CourseName = "Fitness Junkie 101", Instructor = "Tyler Lindley", Location = "Bayfield", PhysicalActivity = "Dance", Time = "Every Tuesday from 9-12pm" },
                new Models.CourseList() { Id = 21, CourseName = "Synchronized Swimming", Instructor = "Justin Hunt", Location = "Mapleton", PhysicalActivity = "Swimming", Time = "Alternating Thursday's from 5-10pm" },
                new Models.CourseList() { Id = 22, CourseName = "Pushup Practice", Instructor = "Alyssa Edwards", Location = "Allandale", PhysicalActivity = "Muscle Gain", Time = "Everyday from 2-4pm" },
                new Models.CourseList() { Id = 23, CourseName = "Monkeybar Cross", Instructor = "Tyler Lindley", Location = "Bayfield", PhysicalActivity = "Climbing", Time = "Every third Monday from 12-10pm" }
                );
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TimeOffSchedule>().HasData(
                new Models.TimeOffSchedule() { Id = 24, Name = "Tyler Lindley", Date = "January 1st to February 4th", CoveredBy = "Mason"},
                new Models.TimeOffSchedule() { Id = 25, Name = "Kyle Scagnetti", Date = "January 1st to February 4th", CoveredBy = "Mason" },
                new Models.TimeOffSchedule() { Id = 26, Name = "Justin Hunt", Date = "Februay 24th to February 29th", CoveredBy = "Tyler" },
                new Models.TimeOffSchedule() { Id = 27, Name = "Mason Ferrie", Date = "Februay 24th to February 29th", CoveredBy = "Tyler" }
                );
        }
    }
}
