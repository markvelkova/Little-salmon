using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace games
{

    public static class SpeedCounting
    {
        public static int MaxOperands { get; set; } = 8;
        public static int MinOperands { get; set; } = 2; // minimum number of operands
        public static int MaxOperandValue { get; set; } = 100; // maximum value of an operand
        public static int MinOperandValue { get; set; } = -100; // minimum value of an operand
        public class Equation
        {
            Random rnd = new Random();
            
            public int[] Operands { get; private set; } // operands of the equation
            public int Sum { get; private set; } // sum of the operands, can be used to check the result
            public string EquationString { get; private set; } // string representation of the equation, can be used to display the equation
            /// <summary>
            /// creates an equation with a given number operands
            /// throws argumentException when wrong number of operators are requested
            /// </summary>
            /// <param name="numberOfOperands"></param>
            /// <exception cref="ArgumentException"></exception>
            public Equation(int numberOfOperands)
            {
                if (numberOfOperands < MinOperands || numberOfOperands > MaxOperands) // arbitrary limits for the number of operands
                    throw new ArgumentException($"Number of operands must be between {MinOperands} and {MaxOperands}.", nameof(numberOfOperands));

                Operands = new int[numberOfOperands];
                for (int i = 0; i < numberOfOperands; i++)
                {
                    int nextOperand = rnd.Next(MinOperandValue, MaxOperandValue + 1); // +1 because upper limit is exclusive
                    Operands[i] = nextOperand; // assign the next operand
                    if (i == 0)
                        Sum = nextOperand; // first operand is the sum
                    else
                        Sum += nextOperand; // add the next operand to the sum
                }
                EquationString = GenerateEquationString();
            }
            private string GenerateEquationString()
            {
                StringBuilder eqBuilder = new StringBuilder();
                for (int i = 0; i < Operands.Length; i++)
                {
                    if (i > 0)
                    {
                        if (Operands[i] >= 0)
                            eqBuilder.Append(" + ");
                        else
                            eqBuilder.Append(" - ");
                    }
                    eqBuilder.Append(Math.Abs(Operands[i]));
                }
                return eqBuilder.ToString();
            }
        }
    }
}
