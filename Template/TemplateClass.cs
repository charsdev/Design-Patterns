using System;

namespace Template
{

    public abstract class TemplateClass
    {
        protected TemplateClass()
        {
            TemplateMethod();
        }

        public void TemplateMethod()
        {
            Console.WriteLine("I am template method");
        }

        public abstract void StepOne();
        public abstract void StepTwo();
        public abstract void StepThree();
        public abstract void StepFour();
    }

}
