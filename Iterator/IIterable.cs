namespace Iterator
{
    partial class Program
    {
        public interface IIterable<out T>
        {
            IIterator<T> CreateIterator();
        }
    }
}
