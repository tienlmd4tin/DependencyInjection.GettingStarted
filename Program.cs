using System;

namespace DependencyInjection.GettingStarted
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var root = IoC.Container.Resolve<ICompositionRoot>();

            root.LogMessage("Hello from my very first resolved class!");

            // Wait for user input so they can check the program's output.
            Console.ReadLine();
        }
    }
}