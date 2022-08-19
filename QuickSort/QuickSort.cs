namespace QuickSort
{
    public class QuickSort
    {
        static void Main()
        {
            var array = new int[] { 3, 6, 2, 9, 8 };

            QuickSortAlgorithm(array);

            foreach (var num in array)
            {
                Console.Write(num + " ");
            }

            Console.ReadLine();
        }

        public static void QuickSortAlgorithm(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        private static void Sort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int partitionIndex = Partition(array, start, end);

                if (partitionIndex > 1)
                {
                    Sort(array, start, partitionIndex - 1);
                }

                if (partitionIndex + 1 < end)
                {
                    Sort(array, partitionIndex + 1, end);
                }
            }
        }

        private static int Partition(int[] array, int start, int end)
        {
            int pivot = array[start];
            int startIndex = start;

            for (int i = start + 1; i <= end; i++)
            {
                if (array[i] < pivot)
                {
                    startIndex++;
                    (array[startIndex], array[i]) = (array[i], array[startIndex]);
                }
            }

            (array[start], array[startIndex]) = (array[startIndex], array[start]);

            return startIndex;
        }
    }
}