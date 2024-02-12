using EntityFramework1.Entities;

namespace EntityFramework1.Repostory
{
    public interface IStudents
    {
        public List<Students> GetStudents();
        public Students GetStudentByID(int id);
        public List<Students> FilterStudentByAge(int Age);
        public List<Students> SearchStudentByName(string name);
        public void AddStudent(Students students);
        public void UpdateStudent(Students students);
        public void UpdateAge(int id ,int age);
        public void DeleteStudent(int id);

    }
}
