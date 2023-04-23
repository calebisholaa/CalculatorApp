using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class Operations
    {

        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Subtraction(int a, int b)
        {
            return  a-b;
        }

        public int Division(int a, int b)
        {
            return a / b;
        }

        //ToDO
        //Multiplication
           

        public int Modulus(int a, int b)
        {
            return (a % b);
        }

    }
}
