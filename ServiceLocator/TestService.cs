using System;
using System.Collections.Generic;

namespace ServiceLocator
{
    public class TestService : IService
    {
        public void Print()
        {
            Console.WriteLine("Testing Service");
        }
    }
}
