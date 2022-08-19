namespace MergeSort
{
    public class MergeSort
    {
        static void Main()
        {
            var array = new int[] { 3, 6, 2, 9, 8 };

            MergeSortAlgorithm(array);

            foreach (var num in array)
            {
                Console.Write(num + " ");
            }

            Console.ReadLine();
        }

        public static void MergeSortAlgorithm(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        private static void Sort(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            var mid = (start + end) / 2;

            Sort(array, start, mid);
            Sort(array, mid + 1, end);

            Merge(array, start, mid, end);
        }

        private static void Merge(int[] array, int start, int mid, int end)
        {
            int i = 0, j = 0, k = start;
            var array1Size = mid - start + 1;
            var array2Size = end - mid;

            var auxArray1 = new int[array1Size];
            var auxArray2 = new int[array2Size];

            Array.Copy(array, start, auxArray1, 0, array1Size);
            Array.Copy(array, mid + 1, auxArray2, 0, array2Size);

            while (i < array1Size && j < array2Size)
            {
                if (auxArray1[i] < auxArray2[j])
                {
                    array[k] = auxArray1[i];
                    i++;
                }
                else
                {
                    array[k] = auxArray2[j];
                    j++;
                }

                k++;
            }

            while (i < array1Size)
            {
                array[k] = auxArray1[i];
                i++;
                k++;
            }

            while (j < array2Size)
            {
                array[k] = auxArray2[j];
                j++;
                k++;
            }
        }
    }
}