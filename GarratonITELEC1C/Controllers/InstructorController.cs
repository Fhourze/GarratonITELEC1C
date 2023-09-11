using Microsoft.AspNetCore.Mvc;
using GarratonITELEC1C.Models;
namespace GarratonITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>()
            {
                new Instructor()
                {
                    Id = 1,
                    FirstName = "Jimmy",
                    LastName = "Gusmanos",
                    IsTenured = true,
                    Rank = Rank.Instructor,
                    HiringDate = DateTime.Parse("12/12/2002"),

                },

                new Instructor()
                {
                    Id = 2,
                    FirstName = "Marsoll",
                    LastName = "Timbre",
                    IsTenured = true,
                    Rank = Rank.AssistantProfessor,
                    HiringDate = DateTime.Parse("25/05/1993"),

                },

                new Instructor()
                {
                    Id = 3,
                    FirstName = "Henry",
                    LastName = "Gusmanos",
                    IsTenured = false,
                    Rank = Rank.Professor,
                    HiringDate = DateTime.Parse("15/08/2023"),

                },

            };
        public IActionResult Instructor()
        {
            return View(InstructorList);
        }
        public IActionResult ShowDetails(int id)
        {
          Instructor? instructor = InstructorList.FirstOrDefault(Instructor => Instructor.Id == id);

            if (instructor != null)
            {
                return View(instructor);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
