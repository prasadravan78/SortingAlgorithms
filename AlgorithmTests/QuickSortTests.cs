namespace AlgorithmTests
{
    using NUnit.Framework;
    using QuickSort;

    /// <summary>
    /// Provides Quick sort tests.
    /// </summary>
    public class QuickSortTests
    {
        /// <summary>
        /// Calls Quick sort with valid inputs.
        /// </summary>
        [Test]
        public void QuickSortValidInput()
        {
            RunTestsForQuickSort(QuickSort.QuickSortAlgorithm);
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

        private static void RunTestsForQuickSort(Action<int[]> quickSortAlgorithm)
        {
            var sampleData = GetSampleData();

            foreach (var sample in sampleData)
            {
                quickSortAlgorithm(sample);
                CollectionAssert.IsOrdered(sample);
                PrintResults(sample);
            }
        }

        private static void PrintResults(int[] sample)
        {
            TestContext.WriteLine("---------------------------------------");

            foreach (var num in sample)
            {
                TestContext.Write(num + " ");
            }

            TestContext.WriteLine("***************************************");
        }
    }
}