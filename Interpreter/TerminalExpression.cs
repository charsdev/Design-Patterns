namespace Interpreter
{
    // TerminalIExpression class implementing
    // the above interface. This Interpreter 
    // just check if the data is same as the 
    // Interpreter data.
    public class TerminalExpression : IExpression
    {
        private readonly string _data;

        public TerminalExpression(string data)
        {
            _data = data;
        }

        public bool Interpreter(string con)
        {
            return con.Contains(_data);
        }
    }
}