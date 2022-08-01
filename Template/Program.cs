using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteClassA concreteClassA = new ConcreteClassA();
            concreteClassA.StepOne();
            concreteClassA.StepTwo();
            concreteClassA.StepThree();
            concreteClassA.StepFour();
            Console.WriteLine("");

            ConcreteClassB concreteClassB = new ConcreteClassB();
            concreteClassB.StepOne();
            concreteClassB.StepTwo();
            concreteClassB.StepThree();
            concreteClassB.StepFour();
        }
    }

}
