﻿// <auto-generated />
using System;
using GymAssignment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GymAssignment.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191203081635_Seeding Data")]
    partial class SeedingData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GymAssignment.Models.CourseList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instructor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhysicalActivity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CourseList");

                    b.HasData(
                        new
                        {
                            Id = 20,
                            CourseName = "Fitness Junkie 101",
                            Instructor = "Tyler Lindley",
                            Location = "Bayfield",
                            PhysicalActivity = "Dance",
                            Time = "Every Tuesday from 9-12pm"
                        },
                        new
                        {
                            Id = 21,
                            CourseName = "Synchronized Swimming",
                            Instructor = "Justin Hunt",
                            Location = "Mapleton",
                            PhysicalActivity = "Swimming",
                            Time = "Alternating Thursday's from 5-10pm"
                        },
                        new
                        {
                            Id = 22,
                            CourseName = "Pushup Practice",
                            Instructor = "Alyssa Edwards",
                            Location = "Allandale",
                            PhysicalActivity = "Muscle Gain",
                            Time = "Everyday from 2-4pm"
                        },
                        new
                        {
                            Id = 23,
                            CourseName = "Monkeybar Cross",
                            Instructor = "Tyler Lindley",
                            Location = "Bayfield",
                            PhysicalActivity = "Climbing",
                            Time = "Every third Monday from 12-10pm"
                        });
                });

            modelBuilder.Entity("GymAssignment.Models.FacultyList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shift")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoreLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FacultyList");

                    b.HasData(
                        new
                        {
                            Id = 11,
                            Department = "Management",
                            HomeAddress = "113 St. Vincent Street",
                            Name = "Tyler Lindley",
                            PhoneNumber = "289-600-0244",
                            Position = "Store Manager",
                            Shift = "Nights",
                            StoreLocation = "Bayfield"
                        },
                        new
                        {
                            Id = 12,
                            Department = "Management",
                            HomeAddress = "152 Bayfield Street",
                            Name = "Mason Ferrie",
                            PhoneNumber = "289-525-1232",
                            Position = "Assistant Store Manager",
                            Shift = "Nights",
                            StoreLocation = "Bayfield"
                        },
                        new
                        {
                            Id = 13,
                            Department = "Management",
                            HomeAddress = "94 Duckworth Street",
                            Name = "Kyle Scagnetti",
                            PhoneNumber = "289-923-1242",
                            Position = "Lead Days Manager",
                            Shift = "Days",
                            StoreLocation = "Allandale"
                        },
                        new
                        {
                            Id = 14,
                            Department = "Management",
                            HomeAddress = "14 Grove Street",
                            Name = "Danil Borisov",
                            PhoneNumber = "289-912-4129",
                            Position = "Assistant Days Manager",
                            Shift = "Days",
                            StoreLocation = "Mapleton"
                        },
                        new
                        {
                            Id = 15,
                            Department = "Fitness Trainer",
                            HomeAddress = "42 Mapleton Avenue",
                            Name = "Justin Hunt",
                            PhoneNumber = "289-921-0193",
                            Position = "Zuumba",
                            Shift = "Nights",
                            StoreLocation = "Mapleton"
                        },
                        new
                        {
                            Id = 16,
                            Department = "Fitness Trainer",
                            HomeAddress = "6 Essa Road",
                            Name = "Alyssa Edwards",
                            PhoneNumber = "289-867-5309",
                            Position = "Dance Teacher",
                            Shift = "Days",
                            StoreLocation = "Allandale"
                        },
                        new
                        {
                            Id = 17,
                            Department = "Security",
                            HomeAddress = "19 Little Avenue",
                            Name = "Jim Smith",
                            PhoneNumber = "289-310-0232",
                            Position = "Security Manager",
                            Shift = "Nights",
                            StoreLocation = "Bayfield"
                        },
                        new
                        {
                            Id = 18,
                            Department = "Security",
                            HomeAddress = "8 Barton Street",
                            Name = "John Johnson",
                            PhoneNumber = "289-652-0551",
                            Position = "On Call Guard",
                            Shift = "Nights",
                            StoreLocation = "Bayfield"
                        },
                        new
                        {
                            Id = 19,
                            Department = "Reception",
                            HomeAddress = "941 Mapleview East",
                            Name = "Abel Daughtry",
                            PhoneNumber = "289-323-5410",
                            Position = "Front Desk",
                            Shift = "Days",
                            StoreLocation = "Allandale"
                        });
                });

            modelBuilder.Entity("GymAssignment.Models.TimeOffSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CoveredBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PostTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TimeOffSchedule");

                    b.HasData(
                        new
                        {
                            Id = 24,
                            CoveredBy = "Mason",
                            Date = "January 1st to February 4th",
                            Name = "Tyler Lindley",
                            PostTime = new DateTime(2019, 12, 3, 3, 16, 35, 315, DateTimeKind.Local).AddTicks(5013)
                        },
                        new
                        {
                            Id = 25,
                            CoveredBy = "Mason",
                            Date = "January 1st to February 4th",
                            Name = "Kyle Scagnetti",
                            PostTime = new DateTime(2019, 12, 3, 3, 16, 35, 319, DateTimeKind.Local).AddTicks(108)
                        },
                        new
                        {
                            Id = 26,
                            CoveredBy = "Tyler",
                            Date = "Februay 24th to February 29th",
                            Name = "Justin Hunt",
                            PostTime = new DateTime(2019, 12, 3, 3, 16, 35, 319, DateTimeKind.Local).AddTicks(146)
                        },
                        new
                        {
                            Id = 27,
                            CoveredBy = "Tyler",
                            Date = "Februay 24th to February 29th",
                            Name = "Mason Ferrie",
                            PostTime = new DateTime(2019, 12, 3, 3, 16, 35, 319, DateTimeKind.Local).AddTicks(155)
                        });
                });

            modelBuilder.Entity("GymAssignment.Models.UsersTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<decimal>("GoalWeight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("PreferredTraining")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<decimal>("StartingWeight")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("UsersTable");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "113 St. Vincent Street",
                            GoalWeight = 150m,
                            Location = "Bayfield",
                            Name = "Tyler Lindley",
                            PhoneNumber = "289-600-0244",
                            PreferredTraining = "Swimming",
                            StartingWeight = 152m
                        },
                        new
                        {
                            Id = 2,
                            Address = "152 Bayfield Street",
                            GoalWeight = 169m,
                            Location = "Bayfield",
                            Name = "Mason Ferrie",
                            PhoneNumber = "289-523-1232",
                            PreferredTraining = "Rock Climbing",
                            StartingWeight = 185m
                        },
                        new
                        {
                            Id = 3,
                            Address = "94 Duckworth Street",
                            GoalWeight = 165m,
                            Location = "Allandale",
                            Name = "Kyle Scagnetti",
                            PhoneNumber = "289-923-1242",
                            PreferredTraining = "Running",
                            StartingWeight = 168m
                        },
                        new
                        {
                            Id = 4,
                            Address = "14 Grove Street",
                            GoalWeight = 152m,
                            Location = "Mapleton",
                            Name = "Danil Borisov",
                            PhoneNumber = "289-912-4129",
                            PreferredTraining = "Long Distance Sprint",
                            StartingWeight = 184m
                        },
                        new
                        {
                            Id = 5,
                            Address = "42 Mapleton Avenue",
                            GoalWeight = 164m,
                            Location = "Mapleton",
                            Name = "Justin Hunt",
                            PhoneNumber = "289-921-0193",
                            PreferredTraining = "Walking",
                            StartingWeight = 195m
                        },
                        new
                        {
                            Id = 7,
                            Address = "6 Essa Road",
                            GoalWeight = 197m,
                            Location = "Allandale",
                            Name = "Jake Smith",
                            PhoneNumber = "289-867-5309",
                            PreferredTraining = "Jump-Rope",
                            StartingWeight = 182m
                        },
                        new
                        {
                            Id = 8,
                            Address = "19 Little Avenue",
                            GoalWeight = 185m,
                            Location = "Bayfield",
                            Name = "Austin Newnez",
                            PhoneNumber = "289-310-0232",
                            PreferredTraining = "Dancing",
                            StartingWeight = 174m
                        },
                        new
                        {
                            Id = 9,
                            Address = "8 Barton Street",
                            GoalWeight = 200m,
                            Location = "Bayfield",
                            Name = "Nathan Jorje",
                            PhoneNumber = "289-652-0551",
                            PreferredTraining = "Gymnastics",
                            StartingWeight = 147m
                        },
                        new
                        {
                            Id = 10,
                            Address = "941 Mapleview East",
                            GoalWeight = 185m,
                            Location = "Allandale",
                            Name = "Cindy Ackinson",
                            PhoneNumber = "289-323-5410",
                            PreferredTraining = "Speed Walking",
                            StartingWeight = 135m
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
