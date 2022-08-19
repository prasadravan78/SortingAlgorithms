namespace AlgorithmTests
{
    using System;
    using NUnit.Framework;
    using SelectionSort;

    /// <summary>
    /// Provides tests for Selection Sort.
    /// </summary>
    public class SelectionSortTests
    {
        /// <summary>
        /// Calls Selection sort with valid inputs.
        /// </summary>
        [Test]
        public void SelectionSortValidInput()
        {
            RunTestsForSelctionSort(SelectionSort.SelectionSortAlgorithm);
        }

        private static void PrintResults(int[] result)
        {
            TestContext.WriteLine("---------------------------------------");

            foreach (var num in result)
            {
                TestContext.Write(num + " ");
            }

            TestContext.WriteLine("***************************************");
        }

        private static int[][] GetSampleData()
        {
            var sampleData = new int[5][];

            sampleData[0] = new int[] { 3, 1 };
            sampleData[1] = new int[] { 9, 5, 8, -1, 4 };
            sampleData[2] = new int[] { 1, 2, 3, 4, 5, 6 };
            sampleData[3] = new int[] { -1 };
            sampleData[4] = new int[] { 5, 0, 6, 7, 8, 9, 2 };

            return sampleData;
        }

        private static void RunTestsForSelctionSort(Func<int[], int[]> selectionSortAlgorithm)
        {
            var sampleData = GetSampleData();

            foreach (var sample in sampleData)
            {
                var result = selectionSortAlgorithm(sample);
                CollectionAssert.IsOrdered(result);
                PrintResults(result);
            }
        }
    }
}
