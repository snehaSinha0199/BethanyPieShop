using Microsoft.AspNetCore.Mvc;
using TeamWork.Models;

namespace TeamWork.Controllers
{
    public class TeamBController : Controller
    {
        private readonly IStudentRepository studentRepository;

        public TeamBController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public ViewResult ListB()
        {
            var StudentB = studentRepository.TeamB();
            ViewBag.StudentB = StudentB.Count();


            return View(StudentB);

        }
    }
}
