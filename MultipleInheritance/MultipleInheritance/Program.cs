using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    interface rat
    {
        void run();


    }
    interface tortoise
    {
        void name();
    }

    class animal: rat, tortoise
    {
        public void run()
        {
            Console.WriteLine("Rat run Fast");
        }
        public void name()
        {
            Console.WriteLine("Tortoise");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            animal obj = new animal();
            obj.run();
            obj.name();
            Console.ReadLine();
        }
    }
}
