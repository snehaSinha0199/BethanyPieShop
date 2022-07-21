namespace TeamWork.Models
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
        IEnumerable<Student> TeamA();
        IEnumerable<Student> TeamB();
        IEnumerable<Student> TeamC();
        IEnumerable<Student> TeamD();

        IEnumerable<Student> GetMaleStudents();

        IEnumerable<Student> GetFemaleStudents();

        IEnumerable<Student> GetFirstNameBYS();

        int UpdateStudent(Student student);
        int CreateStudent(Student student);
        int DeleteStudent(Student student); 


    }
}
