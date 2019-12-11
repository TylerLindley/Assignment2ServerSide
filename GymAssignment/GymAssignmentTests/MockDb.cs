using Couchbase.Management;
using GymAssignment.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymAssignmentTests
{
     public static class EntityExtensions
        {
            public static void Clear<T>(this DbSet<T> dbSet) where T : class
            {
                dbSet.RemoveRange(dbSet);
            }
        }
        public class MockDb
        {
            public static ApplicationDbContext CreateMockDb()
            {
                var options = new DbContextOptionsBuilder<ApplicationDbContext>().
                    UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            using (var context = new ApplicationDbContext(options))
            {
                //context.UsersTable.Add(new User { Name = "Tyler Lindley" }); //, Address = "113 St. Vincent Street", GoalWeight = 150, StartingWeight = 152, Location = "Bayfield", PhoneNumber = "289-600-0244", PreferredTraining = "Swimming" });
                  //  context.SaveChanges();
                }
                return new ApplicationDbContext(options);
            }
        }
    }
