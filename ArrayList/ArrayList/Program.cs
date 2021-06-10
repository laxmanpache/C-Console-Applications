using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExample

{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList(10);
            arr.Add(100);
            Console.WriteLine(arr.Capacity);
            arr.Add(10);
            arr.Add(20);
            arr.Add(40);
            arr.Add(90);

            Console.WriteLine(arr.Capacity);
            foreach(object obj in arr)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            arr.Insert(3,200);
            foreach (object obj in arr)
            {
                Console.Write(obj + " ");
            }
            arr.Remove(100);
            Console.WriteLine();
            foreach (object obj in arr)
            {
                Console.Write(obj + " ");
            }
            arr.RemoveAt(3);
            Console.WriteLine();
            foreach (object obj in arr)
            {
                Console.Write(obj + " ");
            }
            arr.RemoveRange(1,2);
            Console.WriteLine();
            foreach (object obj in arr)
            {
                Console.Write(obj + " ");
            }
            Console.ReadLine();
        }
    }
}
