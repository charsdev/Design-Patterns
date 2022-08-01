using System;

namespace Template
{

    public class ConcreteClassA : TemplateClass
    {
        public override void StepFour()
        {
            Console.WriteLine("Concrete Class A step number FOUR");
        }

        public override void StepOne()
        {
            Console.WriteLine("Concrete Class A step number ONE");
        }

        public override void StepTwo()
        {
            Console.WriteLine("Concrete Class A step number TWO");
        }

        public override void StepThree()
        {
            Console.WriteLine("Concrete Class A step number THREE");
        }
    }

}
