using Microsoft.AspNetCore.Mvc;
using GarratonITELEC1C.Models;
using GarratonITELEC1C.Services;
using GarratonITELEC1C.Data;

namespace GarratonITELEC1C.Controllers
{
    public class InstructorController : Controller
    {

        private readonly AppDbContext _dbContext;

        public InstructorController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }



        public IActionResult Instructor()
        {
            return View(_dbContext.Instructors);
        }



        public IActionResult ShowDetails(int id)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(Instructor => Instructor.Id == id);

            if (instructor != null)
            {
                return View(instructor);
            }
            else
            {
                return NotFound();
            }
        }


        [HttpGet]
        public IActionResult AddInstructor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _dbContext.Instructors.Add(newInstructor);
            _dbContext.SaveChanges();
            return RedirectToAction("Instructor");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(Instructor => Instructor.Id == id);

            if (instructor != null)
            {
                return View(instructor);
            }
            else
            {

                return NotFound();
            }

        }

        [HttpPost]
        public IActionResult Edit(Instructor instructorChange)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(Instructor => Instructor.Id == instructorChange.Id);
            if (Instructor != null)
            {
                instructor.Id = instructorChange.Id;
                instructor.FirstName = instructorChange.FirstName;
                instructor.LastName = instructorChange.LastName;
                instructor.IsTenured = instructorChange.IsTenured;
                instructor.HiringDate = instructorChange.HiringDate;
                instructor.Rank = instructorChange.Rank;
            }
            return RedirectToAction("Instructor");
        }





        [HttpGet]
        public IActionResult DeleteInstructor(int id)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(Instructor => Instructor.Id == id);

            if (instructor != null)
            {
                return View(instructor);
            }
            else
            {
                return NotFound();
            }
        }


        [HttpPost]
        public IActionResult DeleteInstructor(Instructor deleteInstructor)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(instructor => instructor.Id == deleteInstructor.Id);
            _dbContext.Instructors.Remove(instructor);
            _dbContext.SaveChanges();
            return RedirectToAction("Instructor");
        }


    }    
}
