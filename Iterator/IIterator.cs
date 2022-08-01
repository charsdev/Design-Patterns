namespace Iterator
{
    partial class Program
    {
        public interface IIterator<out T>
        {
            T Next { get; }

            bool HasMore();
        }
    }
}
