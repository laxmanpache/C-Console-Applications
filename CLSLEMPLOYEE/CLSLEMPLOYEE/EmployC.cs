using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLSLEMPLOYEE
{
    public class EmployC
    {
        static List<Employ> employList;
        static EmployC()
        {
            employList = new List<Employ>();

        }

        public string Deleterec(int eno)
        {
            Employ obj = SerchEmploy(eno);
            if (obj != null)
            {
                employList.Remove(obj);
                return "record Deleted Successfully ";
            }
            else
            {
                return " Record not found";
            }
        }

        public string updateemp(Employ updateEMP)
        {

            Employ res = SerchEmploy(updateEMP.eno);

            if (res != null)

            {
                foreach (Employ e in employList)
                {
                    if (e.eno == updateEMP.eno)
                    {
                        //flag = true;
                        e.ename = updateEMP.ename;
                        e.Basic = updateEMP.Basic;
                    }
                }
                return "record updated";

            }

            return "record not found";


        }

        public Employ SerchEmploy(int eno)
        {
            Employ empl = null;
            foreach (Employ e in employList)
            {
                if (e.eno == eno)
                {
                    empl = e;
                }


            }
            return empl;
        }
        public string AddEmploy(Employ employ)
        {
            employList.Add(employ);
            return "Employee Added sucessfully";
        }
        public List<Employ> show()
        {
            return employList;
        }
    }
}
