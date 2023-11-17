using DelRosarioITELEC1C.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DelRosarioITELEC1C.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    Id = 1,
                    FirstName = "Mark",
                    LastName = "Padua",
                    Course = Course.BSIT,
                    AdmissionDate = DateTime.Parse("2022-04-25"),
                    GPA = 1.5,
                    Email = "babykoy@gmail.com"
                },
                new Student()
                {
                    Id = 2,
                    FirstName = "Francis",
                    LastName = "Casas",
                    Course = Course.BSIS,
                    AdmissionDate = DateTime.Parse("2022-10-12"),
                    GPA = 1.5,
                    Email = "francas1012@gmail.com"
                },
                new Student()
                {
                    Id = 3,
                    FirstName = "Mikoy",
                    LastName = "Yokim",
                    Course = Course.BSCS,
                    AdmissionDate = DateTime.Parse("2020-01-16"),
                    GPA = 1.5,
                    Email = "yokimik0@gmail.com"
                 });

            modelBuilder.Entity<Instructor>().HasData(
                 new Instructor()
                 {
                     Id = 1,
                     FirstName = "Sana",
                     LastName = "Minatozaki",
                     IsTenured = true,
                     Rank = Rank.Professor,
                     HiringDate = DateTime.Parse("05/05/2023")
                 },
                new Instructor()
                {
                    Id = 2,
                    FirstName = "Jihyo",
                    LastName = "Park",
                    IsTenured = true,
                    Rank = Rank.AssistantProfessor,
                    HiringDate = DateTime.Parse("05/05/2023")
                });
            }
        }
    }



