namespace BubbleSort
{
    public class BubbleSort
    {
        static void Main(string[] args)
        {
            var array = new int[] { 3, 6, 2, 9, 8 };

            var result = BubbleSortAlgorithm(array);

            foreach (var num in result)
            {
                Console.Write(num + " ");
            }

            Console.ReadLine();
        }

        public static int[] BubbleSortAlgorithm(int[] nums)
        {
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
                    }
                }
            }

            return nums;
        }
    }
}