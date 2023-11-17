using Microsoft.AspNetCore.Mvc;

namespace DelRosarioITELEC1C.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Employee()
        {
            return View();
        }
    }
}
