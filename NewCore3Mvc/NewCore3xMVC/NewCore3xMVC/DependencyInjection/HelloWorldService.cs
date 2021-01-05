using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewCore3xMVC.DependencyInjection
{
    public class HelloWorldService : IHelloWorldService
    {
        public string SaysHello()
        {
            return "Hello";
        }
    }
}
