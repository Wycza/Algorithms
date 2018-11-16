using System;

namespace EquilibriumIndex {
    class Program {
        static void Main (string[] args) {
            int[] numbers = new int[] {-1, 3, -4, 5, 1, -6, 2, 1 };

            Console.WriteLine (Equilibrium.FindFirstEquilibriumIndexFaster (numbers));
            Console.WriteLine (Equilibrium.FindFirstEquilibriumIndex (numbers));
        }
    }
}