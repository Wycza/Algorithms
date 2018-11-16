using System;
using System.Collections.Generic;
using System.Linq;

namespace EquilibriumIndex {
    class Equilibrium {
        /// <summary>
        /// This method finds first occurance of equilibrium index.
        /// Algorithm sum left and right side according to current index in for loop.
        /// If left and right sum are the same then equilibrium index was found.
        /// Time complexity O(n^2).
        /// </summary>
        ///
        /// <param name="A">Array of ints</param>
        ///
        /// <returns>
        /// - On success: return equilibrium index
        /// - On failure: return -1
        /// </returns>
        public static int FindFirstEquilibriumIndex (int[] A) {
            for (int i = 0; i < A.Length; i++) {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++) {
                    leftSum += A[j];
                }
                for (int j = i + 1; j < A.Length; j++) {
                    rightSum += A[j];
                }

                if (leftSum == rightSum) {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// This method find all occurances of equilibrium indexes.
        /// It sum left and right side according to current index in for loop.
        /// If left and right sum are the same then equilibrium index was found.
        /// Time complexity O(n^2).
        /// </summary>
        ///
        /// <param name="A">Array of ints</param>
        ///
        /// <returns>
        /// - On success: return list of equilibrium indexes
        /// - On failure: return empty list
        /// </returns>
        public static List<int> FindAllEquilibriumIndexes (int[] A) {
            List<int> EquilibriumIndexes = new List<int>();

            for (int i = 0; i < A.Length; i++) {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++) {
                    leftSum += A[j];
                }
                for (int j = i + 1; j < A.Length; j++) {
                    rightSum += A[j];
                }

                if (leftSum == rightSum) {
                    EquilibriumIndexes.Add(i);
                }
            }

            return EquilibriumIndexes;
        }

        /// <summary>
        /// This method finds first occurance of equilibrium index.
        /// Algorithm sum whole array and then iterate through it.
        /// Time complexity O(n).
        /// </summary>
        ///
        /// <param name="A">Array of ints</param>
        ///
        /// <returns>
        /// - On success: return equilibrium index
        /// - On failure: return -1
        /// </returns>
        public static int FindFirstEquilibriumIndexFaster (int[] A) {
            int sum = A.Sum();
            int leftSum = 0;

            for (int i = 0; i < A.Length; i++) {
                sum -= A[i];

                if (leftSum == sum) {
                    return i;
                }

                leftSum += A[i];
            }

            return -1;
        }
    }
}