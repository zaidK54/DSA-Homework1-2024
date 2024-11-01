using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace DSA_Homework1.TestClasses
{
    [TestClass]
    public class SearcherTests
    {
        [TestMethod]
        public void TernarySearch_FindsElement()
        {
            var searcher = new Searcher();
            int[] array = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };

            int result = searcher.TernarySearch(array, 9, 0, array.Length);

            Assert.AreEqual(4, result, "Ternary search failed to find the target element.");
        }

        [TestMethod]
        public void TernarySearch_DoesNotFindNonExistentElement()
        {
            var searcher = new Searcher();
            int[] array = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };

            int result = searcher.TernarySearch(array, 8, 0, array.Length);

            Assert.AreEqual(-1, result, "Ternary search returned an incorrect index for a non-existent element.");
        }

        [TestMethod]
        public void TernarySearch_FindsElementAtBeginning()
        {
            var searcher = new Searcher();
            int[] array = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };

            int result = searcher.TernarySearch(array, 1, 0, array.Length);

            Assert.AreEqual(0, result, "Ternary search failed to find the element at the beginning.");
        }


        [TestMethod]
        public void UsesRecursion()
        {
            // Path to the file containing the Converter class
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\HomeworkClasses\Searcher.cs");

            bool isInsideMethod = false;
            bool hasRecursiveCall = false;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Trim whitespace for easier processing
                    line = line.Trim();

                    // Detect the start of the TernarySearch method
                    if (line.StartsWith("public int TernarySearch"))
                    {
                        isInsideMethod = true;
                        continue;
                    }

                    // If we're inside the method, check for recursive calls
                    if (isInsideMethod)
                    {
                        // Check if the line contains a call to TernarySearch
                        if (line.Contains(" TernarySearch(") && !line.StartsWith("//"))
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
            Assert.IsTrue(hasRecursiveCall, "TernarySearch does not use recursion as expected.");
        }
    }
}
