using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod
{

   public abstract class Trening {

        public abstract void name();
        public abstract void email();
    
    }

    class rahul : Trening
    {
        public override void email()
        {
            Console.WriteLine("Email is : rahul@123gmail.com");
        }

        public override void name()
        {
            Console.WriteLine("My name is Rahul");
        }
    }

    public class Shyam : Trening
    {
        public override void email()
        {
            Console.WriteLine("Email is : rahul@123gmail.com");
        }

        public override void name()
        {
            Console.WriteLine("My name is Laxman");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Trening[] arr = new Trening[] {

                new rahul(),new Shyam()
            };
            foreach(Trening t in arr)
            {
                t.name();
                t.email();

            }
       
        Console.ReadLine();

        }
    }
}
