using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLSLEMPLOYEE
{
    public class Employ
    {
        public int eno { get; set; }
        public string ename { get; set; }
        public double Basic { get; set; }

        public override string ToString()
        {
            return " number:" + eno + "  Name:" + ename + "  Basic:" + Basic;
        }
    }
}
