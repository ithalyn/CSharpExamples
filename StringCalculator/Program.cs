using System;
using System.Net.Mime;

namespace StringCalculator {
    class Program {
        private static bool Recurse { get; set; }

        static void Main(string[] args){
            if (args.Length > 0){
                ProcessInput(args[0]);
            }
            else RunApplicationMode();
        }

        private static void DisplayResult(Equation equation){
            Console.WriteLine(equation.ToString());
        }

        private static void RunApplicationMode(){
            Console.WriteLine("Please enter an equation:");
            var input = Console.ReadLine();
            if (input.ToLower() != "exit" && input != string.Empty){
                ProcessInput(input);
                if(Recurse) RunApplicationMode();
            }
        }

        private static void ProcessInput(string input){
            try{
                var equation = new Equation(input);
                equation.Calculate();
                DisplayResult(equation);
            }
            catch (ArgumentException){
                Console.WriteLine("you can only use +, -, *, / in this example.");
            }
            catch{
                Console.WriteLine("An error has occured, your memory may have been corrupted. Do you wish to continue?");
                Recurse = Console.ReadLine().ToLower() != "no";
            }
            finally{
                Console.WriteLine("-------------------------------------------");
            }
        }
    }
}
