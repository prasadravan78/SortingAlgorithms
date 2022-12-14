namespace AlgorithmTests
{
    using BubbleSort;
    using NUnit.Framework;

    /// <summary>
    /// Provides Bubble Sort tests.
    /// </summary>
    public class BubbleSortTests
    {
        /// <summary>
        /// Calls Bubble sort method with valid Inputs.
        /// </summary>
        [Test]
        public void BubbleSortValidInput()
        {
            RunTestsForBubbleSort(BubbleSort.BubbleSortAlgorithm);
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

        private static void RunTestsForBubbleSort(Func<int[], int[]> sortAlgorithm)
        {
            var sampleData = GetSampleData();

            foreach (var sample in sampleData)
            {
                var result = sortAlgorithm(sample);
                CollectionAssert.IsOrdered(result);
                PrintResults(result);
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