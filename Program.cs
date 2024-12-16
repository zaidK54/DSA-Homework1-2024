using DSA_Homework1.HomeworkClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Decimal:\t");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Binary code:\t" + (new Converter()).DecimalToBinary(num));


            Console.WriteLine("=============================================");


            var searcher = new Searcher();
            Console.Write("Our array :\t");
            int[] array = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("Searching array:\t");
            int.TryParse(Console.ReadLine(), out num);
            int result = searcher.TernarySearch(array, num, 0, array.Length);
            Console.WriteLine("Element Found at " + result);
        }
    }
}
