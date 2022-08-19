namespace SelectionSort
{
    /// <summary>
    /// Provides methods for Selection Sort.
    /// </summary>
    public class SelectionSort
    {
        /// <summary>
        /// Entry point for Program.
        /// </summary>
        public static void Main()
        {
            var array = new int[] { 9, 5, 8, -1, 4 };

            SelectionSortAlgorithm(array);

            foreach (var num in array)
            {
                Console.Write(num + " ");
            }

            Console.ReadLine();
        }

        public static int[] SelectionSortAlgorithm(int[] nums)
        {
            for (int i = nums.Length - 1; i > 0; i--)
            {
                var largetstElementIndex = 0;

                for (int j = 1; j <= i; j++)
                {
                    if (nums[j] > nums[largetstElementIndex])
                    {
                        largetstElementIndex = j;
                    }
                }

                SwapArrayElements(nums, largetstElementIndex, i);
            }

            return nums;
        }

        private static void SwapArrayElements(int[] nums, int i, int j)
        {
            (nums[i], nums[j]) = (nums[j], nums[i]);
        }
    }
}