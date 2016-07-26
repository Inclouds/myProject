using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using WebSinglePageTest.Models;
using WebSinglePageTest.Providers;
using WebSinglePageTest.Repositories;

namespace WebSinglePageTest.Controllers
{
    public class RepoController : Controller
    {
        private readonly ICourseRepository courseRepository;
        private readonly IInstructorRepository instructorRepository;

        public RepoController(IInstructorRepository instructorRepository, ICourseRepository courseRepository)
        {
            this.instructorRepository = instructorRepository;
            this.courseRepository = courseRepository;
        }

        public ActionResult GetCourses()
        {
            var jsonProvider = new JsonCollectionProvider<Course>(courseRepository);
            return Json(jsonProvider.GetSerialized(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetInstructors()
        {
            var jsonProvider = new JsonCollectionProvider<Instructor>(instructorRepository);
            return Json(jsonProvider.GetSerialized(), JsonRequestBehavior.AllowGet);
        }

    }
}
