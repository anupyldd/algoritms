using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algos.src
{
    public class Sort
    {
        /*
         * Insertion sort
         * - Space complexity: O(1)
         * - Time complexity:
         *      Best case (array is already sorted):        O(n)
         *      Average case (array is randomly sorted):    O(n*n)
         *      Worst case (array is reversely sorted):     O(n*n)
         * - Stable: yes
         */
        public static void InsertionSort<T>(T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
            {
                T key = array[i];
                int j = i - 1;
                while(j >= 0 && array[j].CompareTo(key) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j+1] = key;
            }
        }

        /*
         * Selection sort
         * - Space complexity: O(1)
         * - Time complexity:
         *      Best case (array is already sorted):        O(n*n)
         *      Average case (array is randomly sorted):    O(n*n)
         *      Worst case (array is reversely sorted):     O(n*n)
         * - Stable: no
         */
        public static void SelectionSort<T>(T[] array) where T : IComparable
        {
            int len = array.Length;
            for(int i = 0; i < len; i++)
            {
                int minI = i;
                for( int j = i + 1;  j < len; j++)
                {
                    if (array[j].CompareTo(array[minI]) < 0) 
                    { 
                        minI = j; 
                    }
                    
                    T tmp = array[minI];
                    array[minI] = array[i];
                    array[i] = tmp;
                }
            }
        }
    }
}
