namespace Interpreter
{
    // OrIExpression class implementing
    // the above interface. This Interpreter 
    // just returns the or condition of the 
    // data is same as the Interpreter data.
    public class OrExpression : IExpression
    {
        private readonly IExpression _expr1;
        private readonly IExpression _expr2;

        public OrExpression(IExpression expr1, IExpression expr2)
        {
            _expr1 = expr1;
            _expr2 = expr2;
        }
        public bool Interpreter(string con)
        {
            return _expr1.Interpreter(con) || _expr2.Interpreter(con);
        }
    }
}