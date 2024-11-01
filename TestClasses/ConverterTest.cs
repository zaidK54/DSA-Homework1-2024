using DSA_Homework1.HomeworkClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSA_Homework1.TestClasses
{
    [TestClass]
    public class ConverterTest
    {
        [TestMethod]
        public void ConvertsDecimalToBinary()
        {
            var converter = new Converter();

            Assert.AreEqual("1101", converter.DecimalToBinary(13));
            Assert.AreEqual("1", converter.DecimalToBinary(1));
            Assert.AreEqual("1010", converter.DecimalToBinary(10));
            Assert.AreEqual("1111111111111111111111111111111", converter.DecimalToBinary(2147483647)); // Max 32-bit int
        }
        [TestMethod]
        public void UsesRecursion()
        {
            // Path to the file containing the Converter class
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\HomeworkClasses\Converter.cs");

            bool isInsideMethod = false;
            bool hasRecursiveCall = false;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Trim whitespace for easier processing
                    line = line.Trim();

                    // Detect the start of the DecimalToBinaryRecursive method
                    if (line.StartsWith("public string DecimalToBinary"))
                    {
                        isInsideMethod = true;
                    }

                    // If we're inside the method, check for recursive calls
                    if (isInsideMethod)
                    {
                        // Check if the line contains a call to DecimalToBinaryRecursive
                        if (line.Contains(" DecimalToBinary(") && !line.StartsWith("//"))
                        {
                            hasRecursiveCall = true;
                            break;
                        }

                        // Detect the end of the method by finding the closing bracket
                        if (line == "}")
                        {
                            isInsideMethod = false;
                        }
                    }
                }
            }

            // Assert that recursion is used in the method
            Assert.IsTrue(hasRecursiveCall, "DecimalToBinaryRecursive does not use recursion as expected.");
        }
    }
}
