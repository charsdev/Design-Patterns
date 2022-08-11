using System;

namespace MVP
{
    class Program
    {
        static void Main(string[] args)
        {
            Student model = RetrieveStudentFromDatabase();
            StudentView view = new StudentView(model);
            view.Print();
        }

        private static Student RetrieveStudentFromDatabase()
        {
            Student student = new Student();
            student.SetName("Robert");
            student.SetRollNo("10");
            return student;
        }
    }
}
