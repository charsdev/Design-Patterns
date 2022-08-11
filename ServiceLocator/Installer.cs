using System;
using System.Collections.Generic;

namespace ServiceLocator
{
    public class Installer
    {
        public void Install()
        {
            var testService = new TestService();
            ServiceLocator.Instance.RegisterService<IService>(testService);
        }
    }
}
