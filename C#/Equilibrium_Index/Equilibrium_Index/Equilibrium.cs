using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equilibrium_Index
{
    class Equilibrium
    {
        /// <summary>
        /// Time complexity O(n^2)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int FirstEquilibriumIndex(int[] A)
        {
            // A = array
            // N - number of elements
            // P - equilibrium index is an integer 0 <= P < N

            for (int i = 0; i < A.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += A[j];
                }
                for (int j = i + 1; j < A.Length; j++)
                {
                    rightSum += A[j];
                }

                if (leftSum == rightSum)
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Time complexity O(n^2)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static List<int> AllEquilibriumIndexes(int[] A)
        {
            // A = array
            // N - number of elements
            // P - equilibrium index is an integer 0 <= P < N
            List<int> EquilibriumIndexes = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += A[j];
                }
                for (int j = i + 1; j < A.Length; j++)
                {
                    rightSum += A[j];
                }

                if (leftSum == rightSum)
                {
                    EquilibriumIndexes.Add(i);
                }
            }

            if (EquilibriumIndexes.Count == 0)
            {
                EquilibriumIndexes.Add(-1);
            }

            return EquilibriumIndexes;
        }

        /// <summary>
        /// Time complexity O(n)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int FirstEquilibriumIndexFaster(int[] A)
        {
            int sum = A.Sum();
            int leftSum = 0;

            for (int i = 0; i < A.Length; i++)
            {
                sum -= A[i];

                if (leftSum == sum)
                {
                    return i;
                }

                leftSum += A[i];
            }

            return -1;
        }
    }
}
