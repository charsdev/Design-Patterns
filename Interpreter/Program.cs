using System;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            IExpression person1 = new TerminalExpression("Chars");
            IExpression person2 = new TerminalExpression("Agaue");
            IExpression isSingle = new OrExpression(person1, person2);
            Console.WriteLine(isSingle.Interpreter("Chars"));

            IExpression vikram = new TerminalExpression("Chars");
            IExpression committed = new TerminalExpression("Committed");
            IExpression isCommitted = new AndIExpression(vikram, committed);
            Console.WriteLine(isCommitted.Interpreter("Chars, Committed"));
            Console.WriteLine(isCommitted.Interpreter("Agaue, Committed"));

            Console.ReadKey();
        }
    }
}