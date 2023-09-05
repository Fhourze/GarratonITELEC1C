using Microsoft.AspNetCore.Mvc;

namespace GarratonITELEC1C.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Employee()
        {
            return View();
        }
    }
}
