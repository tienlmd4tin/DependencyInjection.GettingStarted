﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.GettingStarted
{
    public class ConsoleWriter : IConsoleWriter
    {
        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
