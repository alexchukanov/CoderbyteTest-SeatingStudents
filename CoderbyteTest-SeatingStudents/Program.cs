using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderbyteTest_SeatingStudents
{
    internal class Program
    {       
        static int MainProgram(int [] arr)
        {
            int k = arr[0]; //K seats
            int occupiedSeats = arr.Length - 1;

            int totalPairs = 3 * k /2 - 2;                    

            List<string> list = new List<string>();

            int p = 1;
            int n = 1;
            int m = 1;

            for (int i = 0; i < k/2; i++)
            {
                list.Add($"{(n++).ToString("00")},{n++.ToString("00")}");

                if (i < k / 2 - 1)
                {                   
                    list.Add($"{(m++).ToString("00")},{(m++ + 1).ToString("00")}");                   
                    list.Add($"{(p++ + 1).ToString("00")},{(p++ + 2).ToString("00")}");
                }
            }

            if (totalPairs != list.Count)
            {
                Console.WriteLine($" Error: totalPairs != list.Count, {totalPairs} != {list.Count}");
            }

            for (int i = 1; i <= occupiedSeats; i++)
            {                
                list.RemoveAll(x => x.Contains(arr[i].ToString("00")));
            }

            return list.Count();
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 12, 2, 6, 7, 11 };
            int[] arr2 = { 6, 4 };
            int[] arr3 = { 8, 1, 8 };

            //int[] arr4 = { 12, 1, 2, 6, 7, 11, 12 };
            //int[] arr5 = { 2, 1 };
            //int[] arr6 = { 4, 2 };
            //int[] arr6 = {4, 4};
            //int[] arr7 = { 4, 1, 4 };
            //int[] arr7 = { 4, 1, 3 };
            //int[] arr8 = { 12, 11, 12 };

            Console.WriteLine( $" Input: [12, 2, 6, 7, 11], Output: {MainProgram(arr1)}"); //6
            Console.WriteLine($" Input: [6, 4], Output: {MainProgram(arr2)}");             //4
            Console.WriteLine($" Input: [8, 1, 8], Output: {MainProgram(arr3)}");          //6
            //Console.WriteLine($" Input: [12, 1, 2, 6, 7, 11, 12], Output: {MainProgram(arr4)}"); //4
            //Console.WriteLine($" Input: [2, 2], Output: {MainProgram(arr5)}"); //0
            //Console.WriteLine($" Input: [4,2], Output: {MainProgram(arr6)}"); //2
            //Console.WriteLine($" Input: [4,4], Output: {MainProgram(arr6)}"); //2
            //Console.WriteLine($" Input: [4,1,4], Output: {MainProgram(arr7)}"); //0
            //Console.WriteLine($" Input: [4,1,3], Output: {MainProgram(arr7)}"); //1
            //Console.WriteLine($" Input: [12, 11], Output: {MainProgram(arr8)}"); //14
           // Console.WriteLine($" Input: [12, 11, 12], Output: {MainProgram(arr8)}"); //13
        }
    }
}
