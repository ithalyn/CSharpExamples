using System;

namespace StringCalculator{
    public class Equation{

        public Equation(string equationText){
            string[] equationParts = equationText.Split(' ');
            OperandA = double.Parse(equationParts[0]);
            OperandB = double.Parse(equationParts[2]);
            Operator = equationParts[1];
        }

        public string Operator { get; protected set; }

        public double OperandA { get; protected set; }

        public double OperandB { get; protected set; }

        public double Result { get; protected set; }

        public void Calculate(){
            
            switch (Operator){
                case "+":
                    Result = OperandA + OperandB;
                    break;
                case "-":
                    Result = OperandA - OperandB;
                    break;
                case "*":
                    Result = OperandA * OperandB;
                    break;
                case "/":
                    Result = OperandA / OperandB;
                    break;
                default:
                    throw new ArgumentException("Invalid operator ");
            }
            
        }

        public override string ToString(){
            return string.Format("{0} {1} {2} = {3}", OperandA, Operator, OperandB, Result);
        }
    }
}