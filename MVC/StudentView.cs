using System;

namespace MVP
{

    public class StudentView
    {
        public void PrintStudentDetails(string studentName, string studentRollNo)
        {
            Console.WriteLine("Student: ");
            Console.WriteLine("Name: " + studentName);
            Console.WriteLine("Roll No: " + studentRollNo);
        }
    }
}
