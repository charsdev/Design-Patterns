namespace Iterator
{
    partial class Program
    {
        public class Person
        {
            public Person(string fName, string lName)
            {
                FirstName = fName;
                LastName = lName;
            }

            public string FirstName { get; }
            public string LastName { get; }
        }
    }
}
