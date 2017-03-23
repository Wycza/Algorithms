using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equilibrium_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { -1, 3, -4, 5, 1, -6, 2, 1 };

            Console.WriteLine(Equilibrium.FirstEquilibriumIndexFaster(numbers));
            Console.WriteLine(Equilibrium.FirstEquilibriumIndex(numbers));

        }
    }
}
