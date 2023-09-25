
using System;
using GarratonITELEC1C.Controllers;
using GarratonITELEC1C.Services;
using GarratonITELEC1C.Models;
        
namespace GarratonITELEC1C.Services
{
    public class MyFakeDataService : IMyFakeDataService
    {
        public List<Instructor> InstructorList { get; }
        public MyFakeDataService()
        {
            InstructorList = new List<Instructor>()
            {
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

        };
            
                
        }


    }
}
