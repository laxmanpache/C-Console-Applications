using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class Program
    {
         public void evenodd(int num)
        {
             if(num%2==0)

            {
                Console.WriteLine("You Entered Number is even");
            }
             else
            {
                Console.WriteLine("You Entered number is odd");
            }
        }
        static void Main(string[] args)
        {

            int num;
            Console.WriteLine("Enter number which you wnat to check even or odd");
            num = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            obj.evenodd(num);
            Console.ReadLine();
        }
    }
}
