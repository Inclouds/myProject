using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSinglePageTest.Models;

namespace WebSinglePageTest.Repositories
{
    public interface IInstructorRepository : IRepository<Instructor>
    {
        IEnumerable<Instructor> Get();
    }
    public class InstructorsRepository : IInstructorRepository
    {
        public IEnumerable<Instructor> Get()
        {
            var instructors = new List<Instructor>()
            {
                new Instructor() {Email = "JakisMail", Name = "HUgo", RoomNumber = 5},
                new Instructor() {Email = "Drugimail", Name = "Ktos", RoomNumber = 6},
                new Instructor() {Email = "TrzeciMail", Name = "NieWiemKto", RoomNumber = 7}
            };
            return instructors;
        } 
    }
}