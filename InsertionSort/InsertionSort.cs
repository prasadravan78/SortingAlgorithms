namespace InsertionSort
{
    public class InsertionSort
    {
        static void Main(string[] args)
        {
            var array = new int[] { 9, 5, 8, -1, 4 };

            InsertionSortAlgorithm(array);

            foreach (var num in array)
            {
                Console.Write(num + " ");
            }

            Console.ReadLine();
        }

        public static int[] InsertionSortAlgorithm(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                var firstUnsorted = nums[i];
                int j;

                for (j = i; j > 0 && nums[j - 1] > firstUnsorted; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[j] = firstUnsorted;
            }

            return nums;
        }
    }
}