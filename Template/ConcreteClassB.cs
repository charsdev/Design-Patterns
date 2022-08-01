using System;

namespace Template
{

    public class ConcreteClassB : TemplateClass
    {
        public override void StepFour()
        {
            Console.WriteLine("Concrete Class B step number FOUR");
        }

        public override void StepOne()
        {
            Console.WriteLine("Concrete Class B step number ONE");
        }

        public override void StepTwo()
        {
            Console.WriteLine("Concrete Class B step number TWO");
        }

        public override void StepThree()
        {
            Console.WriteLine("Concrete Class B step number THREE");
        }
    }

}
