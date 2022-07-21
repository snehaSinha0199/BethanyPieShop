using TeamWork.Models;
using Microsoft.AspNetCore.Mvc;

namespace TeamWork.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public ViewResult List()
        {
            var students = studentRepository.GetAllStudents();
            return View(students);
        }
        public ViewResult GetMaleStudents()
        {

            var students = studentRepository.GetMaleStudents();

            return View(students);
        }

        public ViewResult GetFemaleStudents()
        {

            var students = studentRepository.GetFemaleStudents();

            return View(students);
        }
        public ViewResult GetFirstNameBYS()
        {
            var students = studentRepository.GetFirstNameBYS();
            return View(students);
        }
        public ViewResult Details(int id2)
        {
            var student = studentRepository.GetAllStudents().FirstOrDefault(student => student.StudentID == id2);
            return View(student);
        }
        
        public ViewResult Create()
        {
            return View();
        }
        public ViewResult Edit(int id)
        {
            var student = studentRepository.GetAllStudents().FirstOrDefault(student => student.StudentID == id);
            return View(student);
        }
        public IActionResult UpdateStudent(Student student)
        {
            studentRepository.UpdateStudent(student);
            return RedirectToAction("List");

        }

        public IActionResult CreateStudent(Student student)
        {
           
           int result= studentRepository.CreateStudent(student);
            return RedirectToAction("List");
        }
        public IActionResult Delete(int id)
        {
            var student = studentRepository.GetAllStudents().FirstOrDefault(student => student.StudentID == id);
           studentRepository.DeleteStudent(student);
            return RedirectToAction("List");
        }


    }
}