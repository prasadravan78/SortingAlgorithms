namespace ShellSort
{
    /// <summary>
    /// Provides methods for shell sort.
    /// </summary>
    public class ShellSort
    {
        /// <summary>
        /// Entry point for Program.
        /// </summary>
        public static void Main()
        {
            var array = new int[] { 3, 6, 2, 9, 8 };

            var result = ShellSortAlgorithm(array);

            foreach (var num in result)
            {
                Console.Write(num + " ");
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Performs shell sort.
        /// </summary>
        /// <param name="array">Input array elemet.</param>
        /// <returns>Sorted Array.</returns>
        public static int[] ShellSortAlgorithm(int[] array)
        {
            int gap = 1;

            while (gap < array.Length / 3)
            {
                gap = (3 * gap) + 1;
            }

            while (gap >= 1)
            {
                for (int i = gap; i < array.Length; i++)
                {
                    for (int j = i; j >= gap && array[j] < array[j - gap]; j -= gap)
                    {
                        (array[j], array[j - gap]) = (array[j - 1], array[j]);
                    }
                }

                gap /= 3;
            }

            return array;
        }
    }
}