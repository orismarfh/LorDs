using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApplication1
{
    class Soma
    {
        public int Param1 { get; set; }
        public int Param2 { get; set; }
        public int Total { get; set; }

        public int Somar(int Param1, int Param2)
        {
            Total = Param1 + Param2;
            return Total;
        }
    }
}
