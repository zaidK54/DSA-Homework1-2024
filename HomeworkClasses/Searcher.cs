using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Homework1
{
    public class Searcher
    {
        public int TernarySearch(int[] array, int target, int left, int right)
        {
            //// TODO: Implement recursive ternary search
            //throw new NotImplementedException();

            if (left > right)
                return -1;

            int mid1 = left + (right - left) / 3;
            int mid2 = right - (right - left) / 3;

            if (array[mid1] == target)
                return mid1;
            if (array[mid2] == target)
                return mid2;

            if (target < array[mid1])
                return TernarySearch(array, target, left, mid1 - 1);
            else if (target > array[mid2])
                return TernarySearch(array, target, mid2 + 1, right);
            else
                return TernarySearch(array, target, mid1 + 1, mid2 - 1);
        }
    }
}
