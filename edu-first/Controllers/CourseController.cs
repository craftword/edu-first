using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using edu_first.Models;
using Microsoft.AspNetCore.Mvc;

namespace edu_first.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository courseRepository;

        public CourseController(ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }

        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Course model)
        {
            if (ModelState.IsValid)
            {
                courseRepository.AddCourse(model);
                return RedirectToAction("index");
            }
            return View();
        }
    }
}