using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.BasicsCSharp
{
    public class BinarySearch
    {
        private static int BinarySearchMethod(int[] array, int item)
        {
            int left = 0;
            int right = array.Length - 1;
            while (left <= right)
            {
                var middle = (left + right) / 2;
                if (array[middle] == item)
                    return middle;
                if (array[middle] == item)
                    return middle - 1;
                else
                    left = middle + 1;
            }
            return -1;
        }
    }
}
