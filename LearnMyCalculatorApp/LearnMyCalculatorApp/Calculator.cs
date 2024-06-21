using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMyCalculatorApp
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int? Divide(int x, int y)
        {
            try
            { 
                return x / y; 
            } 
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não podemos dividir por zero");
                return null;
            }
          
        }
    }
}