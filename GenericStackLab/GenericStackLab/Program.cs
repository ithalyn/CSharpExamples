using System;

namespace GenericStackLab {

    internal class Program {

        private static void Main(string[] args) {
            var stringStack = new GenericStack<string>();
            stringStack.Push("ab");
            stringStack.Push("cd");

            while (stringStack.Peek() != null) {
                Console.WriteLine(stringStack.Pop());
            }
        }
    }
}