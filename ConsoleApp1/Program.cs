using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = Run.OperationGet("+");
            Console.WriteLine(result);
        }
    }
    public class Run
    {
        static Func<float, float, float> Addition = (a, b) => a + b;
        static Func<float, float, float> Subtraction = (a, b) => a - b;
        static Func<float, float, float> Multiplication = (a, b) => a * b;
        static Func<float, float, float> Division = (a, b) => a / b;

        static Dictionary<string, Func<float,float,float>> Operators = new Dictionary<string, Func<float,float,float>>()
        {
            {"+",Addition },
            {"-",Subtraction },
            {"*",Multiplication },
            {"/",Division }
        };

      public static Func<float,float,float> OperationGet(string something)
        {
           foreach(string sign in Operators.Keys)
            {
                if (sign == something)
                {
                    return Operators[sign];
                }
                
            }
            return (x,y) => 0;
        }

    }
}