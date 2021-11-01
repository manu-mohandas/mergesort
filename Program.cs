using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 6, 8, 17, 11, 36, 19, 13, 25, 21, 32 };
            MergeSort(input, 0, input.Length - 1);
        }

        public static void MergeSort(int[] array, int start, int end)
        {        
            if (start < end)
            {
                int mid = (start + end) / 2;
                MergeSort(array, start, mid);
                MergeSort(array, mid + 1, end);
                Merge(array, start, mid, end);
            }

        }

        public static void Merge(int[] array, int low, int mid, int high)
        {
            
            int l = mid - low + 1;
            int r = high - mid;

            int[] a = new int[l];
            int[] b = new int[r];
            
           

            for (int i = 0; i < l; i++)
            {
                a[i] = array[low + i];
            }

            for (int j = 0; j < r; j++)
            {
                b[j] = array[mid + j + 1];
            }

            int left = 0, right = 0;
            int k = low;

            while (left < l && right < r)
            {
                if (a[left] <= b[right])
                {
                    array[k++] = a[left++];
                }
                else
                {
                    array[k++] = b[right++];
                }
            }

            while(left < l)
            {
                array[k++] = a[left++];
            }

            while (right < r)
            {
                array[k++] = b[right++];
            }

            
        }
    }
}
