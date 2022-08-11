using System.Globalization;

namespace ShellSort
{
    public class ShellSort
    {
        static void Main(string[] args)
        {
            var array = new int[] { 3, 6, 2, 9, 8 };

            var result = ShellSortAlgorithm(array);

            foreach (var num in result)
            {
                Console.Write(num + " ");
            }

            Console.ReadLine();
        }

        public static int[] ShellSortAlgorithm(int[] array)
        {
            int gap = 1;

            while (gap < array.Length / 3)
            {
                gap = 3 * gap + 1;
            }

            while (gap >= 1)
            {
                for (int i = gap; i < array.Length; i++)
                {
                    for (int j = i; j >= gap && array[j] < array[j - gap]; j = j - gap)
                    {
                        (array[j], array[j - gap]) = (array[j - 1], array[j]);
                    }
                }

                gap = gap / 3;
            }

            return array;
        }
    }
}