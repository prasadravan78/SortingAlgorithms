namespace AlgorithmTests
{
    using System;
    using InsertionSort;
    using NUnit.Framework;

    internal class InsertionSortTests
    {
        [Test]
        public void InsertionSortValidInputs()
        {
            RunTestsForInsertionSort(InsertionSort.InsertionSortAlgorithm);
        }

        private static void RunTestsForInsertionSort(Func<int[], int[]> insertionSortAlgorithm)
        {
            var sampleData = GetSampleData();

            foreach (var sample in sampleData)
            {
                var result = insertionSortAlgorithm(sample);
                CollectionAssert.IsOrdered(result);
                PrintResults(result);
            }
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
    }
}
