using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderbyteTest_SeatingStudents
{
    internal class Program
    {
        //arr = [12, 2, 6, 7, 11]  return 6,   [2,1] => 0
        static int MainProgram(int [] arr)
        {
            int k = arr[0]; //K seats
            int occupiedSeats = arr.Length - 1;

            int totalPairs = 3 * k /2 - 2;

            int occupiedPairs = 0;

            for (int i = 1; i <= occupiedSeats; i++)
            {
                if (arr[i] == 1 || arr[i] == 2 || arr[i] == k || arr[i] == k-1)
                {
                    occupiedPairs += 2;
                }
                else 
                {
                    occupiedPairs += 3;
                }
            }

            int seatStudents = totalPairs - occupiedPairs;

            return seatStudents;
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 12, 2, 6, 7, 11 };
            int[] arr2 = { 6, 4 };
            int[] arr3 = { 8, 1, 8 };

            Console.WriteLine( $" Input: [12, 2, 6, 7, 11], Output: {MainProgram(arr1)}"); //6
            Console.WriteLine($" Input: [6, 4], Output: {MainProgram(arr2)}");             //4
            Console.WriteLine($" Input: [8, 1, 8], Output: {MainProgram(arr3)}");          //6

        }
    }
}
