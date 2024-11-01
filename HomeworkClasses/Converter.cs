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
            //// TODO: convert decimal number to binary code using recursion
            //throw new NotImplementedException();

            // Base case: if number is 0, return an empty string
            if (decimalNumber == 0)
                return "";

            // Recursive call to get the binary representation of the quotient
            return DecimalToBinary(decimalNumber / 2) + (decimalNumber % 2).ToString();
        }
    }
}
