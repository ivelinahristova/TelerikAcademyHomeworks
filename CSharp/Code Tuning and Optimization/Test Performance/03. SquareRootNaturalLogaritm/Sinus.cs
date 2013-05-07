using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SquareRootNaturalLogaritm
{
    public static class Sinus
    {
        public static void Float(float startNumber, float endNumber)
        {
            for (float i = startNumber; i < endNumber; i += 0.1f)
            {
                Math.Sin(i);
            }
        }

        public static void Double(double startNumber, double endNumber)
        {
            for (double i = startNumber; i < endNumber; i += 0.1)
            {
                Math.Sin(i);
            }
        }

        public static void Decimal(decimal startNumber, decimal endNumber)
        {
            for (decimal i = startNumber; i < endNumber; i += 0.1m)
            {
                Math.Sin((double)i);
            }
        }
    }
}
