using ContactsManager.Core.Domain.IdentityEntities;
using TaskInfo.Core.Domain.Entities;
using TaskInfo.Core.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace TaskInfo.Infrastructure.DbContexts
{
    public class TaskOrderDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {

        public TaskOrderDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<MyTask> AllTasksTable { get; set; }

        public DbSet<User> AllUsersTable { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {


            base.OnModelCreating(builder);

            builder.Entity<MyTask>().ToTable("AllTasksTable");
            builder.Entity<User>().ToTable("AllUsersTable");

            builder.Entity<MyTask>().Property(t => t.Status).HasConversion(
                    v => v.ToString(), // enum to string for storage
                    v => (CustomTaskStatus)Enum.Parse(typeof(CustomTaskStatus), v) // string back to enum
            );

            Guid roleid = Guid.NewGuid();
            Guid roleid2 = Guid.NewGuid();

            builder.Entity<ApplicationRole>().HasData(
            new ApplicationRole { Name = "Admin", NormalizedName = "ADMIN", Id = roleid },
            new ApplicationRole { Name = "User", NormalizedName = "USER", Id = roleid2 }
        );

            Guid id = Guid.NewGuid();
            Guid id2 = Guid.NewGuid();

            var passwordHasher = new PasswordHasher<ApplicationUser>();


            builder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    UserName = "admin",
                    Id = id,
                    PasswordHash = passwordHasher.HashPassword(null, "Admin301@"),
                    NormalizedUserName = "ADMIN",
                    SecurityStamp = Guid.NewGuid().ToString()
                },
                new ApplicationUser()
                {
                    UserName = "user",
                    Id = id2,
                    PasswordHash = passwordHasher.HashPassword(null, "User301@"),
                    NormalizedUserName = "USER",
                    SecurityStamp = Guid.NewGuid().ToString()
                }
            );

            builder.Entity<MyTask>().HasData(
                new MyTask()
                {
                    Title = "Test",
                    Description = "Test Description",
                    UserId = id2,
                    DueDate = DateTime.Now.AddDays(5),
                    Status = CustomTaskStatus.Completed
                },
                new MyTask()
                {
                    Title = "Test2",
                    Description = "Test 2",
                    UserId = id2,
                    DueDate = DateTime.Now.AddDays(10),
                    Status = CustomTaskStatus.Pending
                });

            builder.Entity<User>().HasData(
                new User
                {
                    UserName = "admin",
                    UserId = id
                },
                new User
                {
                    UserName = "user",
                    UserId = id2
                }
                );

            // role table

            builder.Entity<IdentityUserRole<Guid>>().HasData(
                new IdentityUserRole<Guid>
                {
                    UserId = id,
                    RoleId = roleid
                },
                new IdentityUserRole<Guid>
                {
                    UserId = id2,
                    RoleId = roleid2
                }

                );

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings =>
                   warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }


    }



}



