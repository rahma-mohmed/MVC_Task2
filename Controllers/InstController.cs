using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Task2.Models;

namespace Task2.Controllers
{
    public class InstController : Controller
    {
        ITIEntities context = new ITIEntities();

        public IActionResult Index()
        {
            
            List<Instructor> instructors = context.Instructors.ToList();
            return View("Index" , instructors);
        }
        
        public IActionResult DepartmentV(int Id)
        {
            List<Department> Dept = context.Departments.Where(x => x.Id == Id).ToList();
            return View("DepartmentV", Dept);
        }

        public IActionResult CourseV(int id)
        {
            List<Course> Courses = context.Courses.Where(x => x.Id == id).ToList();
            return View("CourseV", Courses);
        }

        public IActionResult CourseV2(int id)
        {
            List<Course> Courses = context.Courses.Where(x => x.Dept_id == id).ToList();
            return View("CourseV", Courses);
        }
    }
}
