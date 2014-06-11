using System;

namespace MyFirstConsoleApplication {

    internal class Program {

        private static void Main(string[] args) {
            if (args.Length > 0) {
                OutputHelloMessage(args[0]);
            }
            else {
                Console.WriteLine("Welcome to my awesome hello world application!");
                ProcessInput();
                Console.WriteLine("goodbye");
            }
        }

        private static void OutputHelloMessage(string name) {
            Console.WriteLine("Hello {0}!", name);
        }

        private static void ProcessInput() {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            if (!name.Equals(string.Empty) && !name.ToLower().Equals("exit")) {
                OutputHelloMessage(name);
                ProcessInput();
            }
        }
    }
}