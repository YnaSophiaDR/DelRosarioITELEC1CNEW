using DelRosarioITELEC1C.Data;
using DelRosarioITELEC1C.Models;
using Microsoft.AspNetCore.Mvc;

namespace DelRosarioITELEC1C.Controllers
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
        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddInstructor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            _dbContext.Instructors.Add(newInstructor);
            _dbContext.SaveChanges();
            return RedirectToAction("Instructor");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == id);
            if (instructor != null)
                return View(instructor);

            return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Instructor instructorChange)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == instructorChange.Id);
            if (instructor != null)
            {
                instructor.Id = instructorChange.Id;
                instructor.FirstName = instructorChange.FirstName;
                instructor.LastName = instructorChange.LastName; ;
                instructor.IsTenured = instructorChange.IsTenured; ;
                instructor.Rank = instructorChange.Rank;
                instructor.HiringDate = instructorChange.HiringDate;
            }
            _dbContext.SaveChanges();
            return RedirectToAction("Instructor");

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(instructor => instructor.Id == id);
            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();

        }

        [HttpPost]
        public IActionResult Delete(Instructor delInst)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == delInst.Id);
            if (instructor != null)
            {
                _dbContext.Instructors.Remove(instructor);
                _dbContext.SaveChanges();
                return RedirectToAction("Instructor");
            }
            return NotFound();
        }

    }
}