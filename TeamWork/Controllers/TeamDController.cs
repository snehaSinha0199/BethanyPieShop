using Microsoft.AspNetCore.Mvc;
using TeamWork.Models;

namespace TeamWork.Controllers
{
    public class TeamDController : Controller
    {
        private readonly IStudentRepository studentRepository;

        public TeamDController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public ViewResult ListD()
        {
            var StudentD = studentRepository.TeamD();
            ViewBag.StudentD = StudentD.Count();


            return View(StudentD);

        }
    }
}
