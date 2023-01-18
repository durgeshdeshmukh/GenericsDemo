using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class PrintArray<T>
    {
        public static void toPrint<T>(T[] inputArray)
        {
            foreach (T element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("----------------------------------");
        }

        //public static void toPrint(int[] inputArray)
        //{
        //    foreach (var element in inputArray)
        //    {
        //        Cons
    }
}
