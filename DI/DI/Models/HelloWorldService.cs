﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Models
{
    public class HelloWorldService : IHelloWorldService
    {
        public string SaysHello()
        {
            return "Hello ";
        }
    }
}
