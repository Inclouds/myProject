using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using Newtonsoft.Json;
using WebSinglePageTest.Models;

namespace WebSinglePageTest.Repositories
{
    public interface ICourseRepository : IRepository<Course>
    {
        IEnumerable<Course> Get();
    }

    public class CoursesRepository : ICourseRepository
    {
        public IEnumerable<Course> Get()
        {
            var courses = new List<Course>()
            {
                new Course() {Instructor = "Ahmed", Name = "Kurs nazwa", Number = 103},
                new Course() {Instructor = "Zbynio", Name = "Kurs stonogi", Number = 105},
                new Course() {Instructor = "Shalom", Name = "Kurs 4p", Number = 106}
            };

            return courses;

        }
    }
}