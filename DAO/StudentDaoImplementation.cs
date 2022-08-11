using System.Collections.Generic;

namespace DAO
{

    public class StudentDaoImplementation : IDao<Student>
    {
        private readonly List<Student> _students;

        public StudentDaoImplementation()
        {
            _students = new List<Student>();
        }

        public List<Student> GetAll()
        {
            return _students;
        }

        public Student Get(int id)
        {
            return _students[id];
        }

        public void Add(Student student)
        {
            _students.Add(student);
        }

        public void Delete(Student student)
        {
            _students.Remove(student);
        }
    
        public void Update(Student student)
        {
            _students[student.GetRollNo()].SetName(student.GetName());
        }
    }
}
