using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberCheck
{
    class Program
    {
          public void check(int num)
        {
            bool flag =false;
           for(int i=2;i<=num/2;i++)
            {
                if(num%i==0)
                {
                    flag = true;
                    break;
                }
            }
           if(flag==true)
            {
                Console.WriteLine("This number is not prime number");
            }
           else
            {
                Console.WriteLine("this number is Prime number");
            }
        }
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter number which you want to check");
            num = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            obj.check(num);
            Console.ReadLine();
        }
    }
}
