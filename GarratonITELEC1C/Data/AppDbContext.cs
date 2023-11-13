using GarratonITELEC1C.Models;
using Microsoft.EntityFrameworkCore;

namespace GarratonITELEC1C.Data
    
{
    public class AppDbContext : DbContext
    {
        public DbSet<Instructor> Instructors { get; set; }  
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Instructor>().HasData(

            new Instructor()
                 {
                     Id = 1,
                     FirstName = "Jimmy",
                     LastName = "Gusmanos",
                     IsTenured = true,
                     Rank = Rank.Instructor,
                     HiringDate = DateTime.Parse("12/12/2002")

                 },

            new Instructor()
            {
                Id = 2,
                FirstName = "Marsoll",
                LastName = "Timbre",
                IsTenured = true,
                Rank = Rank.AssistantProfessor,
                HiringDate = DateTime.Parse("25/05/1993")

            },

            new Instructor()
            {
                Id = 3,
                FirstName = "Henry",
                LastName = "Gusmanos",
                IsTenured = false,
                Rank = Rank.Professor,
                HiringDate = DateTime.Parse("15/08/2023")

            }
                );
        }



    }
}
