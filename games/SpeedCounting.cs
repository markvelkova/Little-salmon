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

        public interface IEquation
        {
            int Solution { get; } // sum of the operands, can be used to check the result
            string EquationString { get; } // string representation of the equation, can be used to display the equation

        }
        
        public class SimpleEquation : IEquation
        {
            

            public static Random rnd = new Random();
            
            public int[] Operands { get; private set; } // operands of the equation
            public int Solution { get; private set; } // sum of the operands, can be used to check the result
            public string EquationString { get; private set; } // string representation of the equation, can be used to display the equation

            /// <summary>
            /// default constructor, creates an equation with a random number of operands
            /// USES THE SPECIFIC CONSTRUCTOR   
            /// </summary>
            public SimpleEquation()
                : this(rnd.Next(MinOperands, MaxOperands + 1))
            {
            }

            /// <summary>
            /// creates an equation with a given number operands only with + and - operators
            /// throws argumentException when wrong number of operators are requested
            /// </summary>
            /// <param name="numberOfOperands"></param>
            /// <exception cref="ArgumentException"></exception>
            public SimpleEquation(int numberOfOperands)
            {
                if (numberOfOperands < MinOperands || numberOfOperands > MaxOperands) // arbitrary limits for the number of operands
                    throw new ArgumentException($"Number of operands must be between {MinOperands} and {MaxOperands}.", nameof(numberOfOperands));

                Operands = new int[numberOfOperands];
                for (int i = 0; i < numberOfOperands; i++)
                {
                    int nextOperand = rnd.Next(MinOperandValue, MaxOperandValue + 1); // +1 because upper limit is exclusive
                    Operands[i] = nextOperand; // assign the next operand
                    if (i == 0)
                        Solution = nextOperand; // first operand is the sum
                    else
                        Solution += nextOperand; // add the next operand to the sum
                }
                EquationString = GenerateEquationString();
            }
            private string GenerateEquationString()
            {
                StringBuilder eqBuilder = new StringBuilder();
                for (int i = 0; i < Operands.Length; i++)
                {
                    if (Operands[i] >= 0)
                    {
                        if (i > 0) // first operand is not preceded by + operator
                            eqBuilder.Append(" + ");
                    }
                    else
                        eqBuilder.Append(" - ");
                    eqBuilder.Append(Math.Abs(Operands[i]));
                }
                return eqBuilder.ToString();
            }
        }
    }
}
