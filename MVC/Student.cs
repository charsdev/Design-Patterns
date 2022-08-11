using System;

namespace MVP
{

    public class Student
    {
        private string _rollNo;
        private string _name;

        public string GetRollNo()
        {
            return _rollNo;
        }

        public void SetRollNo(string rollNo)
        {
            _rollNo = rollNo;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }
    }
}
