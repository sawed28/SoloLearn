using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoop2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while(num < 6)
            {
                Console.WriteLine(num);
                num += 2;
            }
        /* Outputs
         1
         2
         3
         5
         */
        }
    }
}
