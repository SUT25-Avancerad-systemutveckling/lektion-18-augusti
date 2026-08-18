using first_mvc_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace first_mvc_app.Controllers
{
    public class StudentController : Controller
    {
        private static readonly List<Student> _students = new()
        {
            new Student
            {
                Id = 1, Name = "Ada", Program = "Backend Dev"
            },
            new Student
            {
                Id = 2, Name = "Grace", Program = "Frontend Dev"
            },
        };
        public IActionResult Index()
        {
            return View(_students);
        }
        
        public IActionResult Details(int id)
        {
            var student = _students.FirstOrDefault(x => x.Id == id);

            if (student == null)
            {
                return RedirectToAction("Index");
            }

            return View(student);
        }
    }
}
