using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6 };

            /* I'm not sure why the code below exists 
             * if we're trying to get the sum of the original array
             * because all it does is add 1 to each item in the array
             * and of course that won't get you 21, it'll get you 27
             */ 

            //int i = 0;
            //for (i = 0; i < array1.Length; i++)
            //{
            //    array1[i]++;
            //}

            int result = GetSum(array1);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        private static int GetSum(int[] array1)
        {
            int sum = 0;

            foreach (int item in array1)
            {
                sum = sum + item;
            }
            return sum;
        }
    }
}
