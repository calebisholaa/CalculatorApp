using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class ParseInput
    {


        public bool IfAddition(string userinput)
        {
            bool result = false;
           char[] chars = userinput.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '+')
                {
                    result = true;
                }
            }

            return result;
        }
        public bool IfSubtraction(string userinput)
        {
            bool result = false;
            char[] chars = userinput.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '-')
                {
                    result = true;
                }
              

            }

            return result;
        }

        public bool IfMultiplication(string userinput)
        {
            bool result = false;
            char[] chars = userinput.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '×')
                {
                    result = true;
                }
            }

            return result;
        }


        public bool IfDivision(string userinput)
        {
            bool result = false;
            char[] chars = userinput.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '÷')
                {
                    result = true;
                }
            }

            return result;
        }
        public List<int> MakeDigit(string userInput)
        {
            char[] chars = userInput.ToCharArray();
            
           

            List<int> result = new List<int>(); 

            List<string> firstDigit = new List<string>();
            List<string> secondDigit = new List<string>();
            List<string> operation = new List<string>();

            for (int i = 0; i < chars.Length; i++)
            {
                if((chars[i] != '+') && (chars[i] != '÷') && (chars[i] != '×') && (chars[i] !='-'))
                {
                  
                    firstDigit.Add(chars[i].ToString());
                           
                }
                else
                {
                    //We have encountered a operational symbol skip and keep storing
                    //to make next digit
                    var second = chars.Skip(i+1);
                    var secondCopy = string.Concat(second);
                    secondDigit.Add(secondCopy);
                    break;

                }
            }

            string a =  string.Concat(firstDigit);
            string b = string.Concat(secondDigit);
           

           result.Add(Int32.Parse(a));

           result.Add(Int32.Parse(b));

           return result;

        }
    }
}
