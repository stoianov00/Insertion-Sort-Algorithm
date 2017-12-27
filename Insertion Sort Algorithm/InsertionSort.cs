using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort 
{
    public class Program
    {
        public static void Main()
        {
            // InsertionSort
            InsertionSort();
        }

        public static void InsertionSort()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int firstIndex = 0; firstIndex < arr.Length - 1; firstIndex++)
            {
                for (int secondIndex = firstIndex + 1; secondIndex > 0; secondIndex--)
                {
                    if (arr[secondIndex - 1] > arr[secondIndex])
                    {
                        int temp = arr[secondIndex - 1];
                        arr[secondIndex - 1] = arr[secondIndex];
                        arr[secondIndex] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
