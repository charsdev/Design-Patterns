using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public interface IHandler
    {
        IHandler SetNextHandler(IHandler handler);
        void HandleRequest(int request);
    }
}