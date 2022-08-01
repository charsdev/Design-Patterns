using System;
using System.Collections.Generic;

namespace DAO
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            IDao<Student> studentDao = new StudentDaoImplementation();
            Student student = new Student("Test", 0);
            studentDao.Add(student);

            //print all students
            foreach (var item in studentDao.GetAll())
            {
                Console.WriteLine("Student: [RollNo : " + item.GetRollNo() + ", Name : " + item.GetName() + " ]");
            }

            //update student
            Student studentToUpdate = studentDao.GetAll()[0];
            studentToUpdate.SetName("Michael");
            studentDao.Update(student);

            //get the student
            studentDao.Get(0);
            Console.WriteLine("Student: [RollNo : " + student.GetRollNo() + ", Name : " + student.GetName() + " ]");
        }
    }
}
