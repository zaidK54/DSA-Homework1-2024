using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Homework1.HomeworkClasses
{
    public class Converter
    {
        public string DecimalToBinary(int decimalNumber)
        {
            // TODO: convert decimal number to binary code using recursion
            string res = string.Empty;
if (decimalNumber > 1)
{
    res += DecimalToBinary(decimalNumber / 2);
}
if (decimalNumber % 2 == 0) return res + "0";
return res + "1";
        }
    }
}
