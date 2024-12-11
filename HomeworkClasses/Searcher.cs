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
            // TODO: Implement recursive ternary search
            int m1 = left + (right - left) / 2;
            int m2 = right - (right - left) / 2;
            if (array[m1] == target) return m1;
            if (array[m2] == target) return m2;
            if (left == right || right - left == 1) return -1;

            if (array[m1] > target) right = m1;
            else left = m1;

            if (array[m2] < target) left = m2;
            return TernarySearch(array, target, left, right);
        }
    }
}
