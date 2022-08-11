using System;
using System.Collections.Generic;

namespace ServiceLocator
{
    class Program
    {
        static void Main(string[] args)
        {
            Installer installer = new Installer();
            installer.Install();

            IService testService = ServiceLocator.Instance.GetService<IService>();
            testService.Print();
        }
    }
}
