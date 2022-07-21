using Microsoft.AspNetCore.Mvc;
using TeamWork.Models;

namespace TeamWork.Controllers
{
    public class TeamAController : Controller
    {
        private readonly IStudentRepository studentRepository;

        public TeamAController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public ViewResult ListA()
        {
            var StudentA = studentRepository.TeamA();
            ViewBag.StudentA = StudentA.Count();


            return View(StudentA);

        }
    }
    }
