namespace DAO
{
    public class Student
    {
        private string _name;
        private int _rollNo;

        public Student(string name, int rollNo)
        {
            _name = name;
            _rollNo = rollNo;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string value)
        {
            _name = value;
        }

        public int GetRollNo()
        {
            return _rollNo;
        }

        public void SetRollNo(int value)
        {
            _rollNo = value;
        }
    }
}
