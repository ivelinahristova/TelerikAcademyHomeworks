using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AddSubstractMultiply
{
    class Program
    {

        static void Main(string[] args)
        {
            Subtract.Integer(10000000, 1, 1);
            Subtract.Long(10000000L, 1L, 1L);
            Subtract.Float(10000000f, 10000000f, 1f);
            Subtract.Double(10000000.0, 1.0, 1.0);
            Subtract.Decimal(10000000m, 1m, 1m);
        }
    }
}
