namespace Iterator
{
    partial class Program
    {
        public class People : Iterable<Person>
        {
            public People(Person[] pArray) : base(pArray)
            {
            }
        }
    }
}
