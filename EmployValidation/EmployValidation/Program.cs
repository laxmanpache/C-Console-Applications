using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployValidation
{
    class validation
    {
        public StringBuilder validate(Employ emp)
        {
            StringBuilder sb = new StringBuilder();
            bool flag = true;
            if(emp.Eno<=0)

            {
                sb.Append("Enter valid Employee Number");
                flag = false;
            }
            if(emp.name.Length<=4)
            {
                sb.Append("Enter valid name length>4");
                flag = false;
            }
            if(emp.DepartMennt.Equals("Physics"))
            {
                sb.Append("Do not choose Physics Department");
                flag = false;
            }
            if (emp.basic < 200)
            {
                sb.Append("Enter basic gereter than 200");
                flag = false;
            }
            if (flag == true)
            {
                sb.Append("All validation are Correct");
            }
            return  sb;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employ emp = new Employ();
            Console.WriteLine("Enter Employee Number");
            emp.Eno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            emp.name = Console.ReadLine();
            Console.WriteLine("Enter Department Name");
            emp.DepartMennt = Console.ReadLine();
            Console.WriteLine("Enter Designation of Employee");
            emp.Designation = Console.ReadLine();
            Console.WriteLine("Enter salary of Employee");
            emp.basic = Convert.ToDouble(Console.ReadLine());
            validation obj = new validation();
           Console.WriteLine( obj.validate(emp));
            Console.ReadLine();


        }
    }
}
