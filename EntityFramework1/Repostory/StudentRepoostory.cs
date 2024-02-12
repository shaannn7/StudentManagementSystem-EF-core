using EntityFramework1.Data;
using EntityFramework1.Entities;

namespace EntityFramework1.Repostory
{
    public class StudentRepoostory : IStudents
    {
        private readonly DbContextClass _dbContextClass;
        public StudentRepoostory(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }



        public List<Students> GetStudents()
        {
            var STD =  _dbContextClass.student.ToList();
            return STD;
        }

        public Students GetStudentByID(int id)
        {
            var FindStd =  _dbContextClass.student.FirstOrDefault(X=>X.StudentId == id);           
            return FindStd;
        }

        public List<Students> FilterStudentByAge(int Age)
        {
            var FindStd = _dbContextClass.student.Where(v => v.StudentAge > Age);
            return FindStd.ToList();

        }

        public List<Students> SearchStudentByName(string name)
        {
            var FindStdnt = _dbContextClass.student.Where(n=>n.StudentName.StartsWith(name));
            return FindStdnt.ToList();
        }


        public void AddStudent(Students students)
        {
            _dbContextClass.student.Add(students);
            _dbContextClass.SaveChanges();
        }

        public void UpdateStudent(Students students)
        {
            var UPDstudent = _dbContextClass.student.FirstOrDefault(i=>i.StudentId == students.StudentId);
            if (UPDstudent != null)
            {
                UPDstudent.StudentName = students.StudentName;
                UPDstudent.StudentAge = students.StudentAge;
            }
            _dbContextClass.SaveChanges();
        }

        public void UpdateAge(int id, int age)
        {
            var FindID = _dbContextClass.student.FirstOrDefault(i => i.StudentId == id);
            if (FindID != null)
            {
                FindID.StudentAge = age;
            }
            _dbContextClass.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            var FindID= _dbContextClass.student.FirstOrDefault(i=>i.StudentId == id);
            if(FindID != null)
            {
                _dbContextClass.Remove(FindID);
            }
            _dbContextClass.SaveChanges();
        }
    }
}
