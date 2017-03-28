using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            double example1 = 12.159309;
            double example2 = 1343591.1;
            double example3 = 0.000003;

            Console.WriteLine(example1.ToString("#.##"));
            Console.WriteLine(example2.ToString("#.##"));
            Console.WriteLine(example3.ToString("#.##"));

            decimal decExample1 = 21.3040349m;
            decimal decExample2 = 12.9999m;
            int randomInt1 = 43;
            int randomInt2 = 21;

            Console.WriteLine("{0:C}", decExample1);
            Console.WriteLine("{0:C}", decExample1+decExample2);


        }
    }
}
