using Microsoft.AspNetCore.Mvc;
using GarratonITELEC1C.Models;
using GarratonITELEC1C.Services;

namespace GarratonITELEC1C.Controllers
{
    public class InstructorController : Controller
    {

        private readonly IMyFakeDataService _fakeData;

        public InstructorController(IMyFakeDataService fakeData)
        {
            _fakeData = fakeData;
        }



        public IActionResult Instructor()
        {
            return View(_fakeData.InstructorList);
        }



        public IActionResult ShowDetails(int id)
        {
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(Instructor => Instructor.Id == id);

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
            _fakeData.InstructorList.Add(newInstructor);
            return RedirectToAction("Instructor");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(Instructor => Instructor.Id == id);

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
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(Instructor => Instructor.Id == instructorChange.Id);
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
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(Instructor => Instructor.Id == id);

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
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(instructor => instructor.Id == deleteInstructor.Id);
            _fakeData.InstructorList.Remove(instructor);
            return RedirectToAction("Instructor");
        }


    }    
}
