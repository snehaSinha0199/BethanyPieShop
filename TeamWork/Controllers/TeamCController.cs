using Microsoft.AspNetCore.Mvc;
using TeamWork.Models;


namespace TeamWork.Controllers
{
    public class TeamCController : Controller
    {
        private readonly IStudentRepository studentRepository;

        public TeamCController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public ViewResult ListC()
        {
            var StudentC = studentRepository.TeamC();
            ViewBag.StudentC = StudentC.Count();


            return View(StudentC);

        }
    }
}
