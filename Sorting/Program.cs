using System.Runtime.InteropServices;

namespace DSA
{
    #region Bubble Sort
    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] arr = { 12, 5, 3, 6, 8, 213, 45, 2, 0, 23 };

    //        //BubbleSort(arr);
    //        BubbleSortImproved(arr);

    //        foreach (int i in arr)
    //            Console.Write(i + " ");
    //    }

    //    static void BubbleSort(int[] arr)
    //    {
    //        for (int pass = arr.Length - 1; pass >= 0; pass--)
    //        {
    //            for (int i = 0; i < pass; i++)
    //            {
    //                if (arr[i] > arr[i + 1])
    //                {
    //                    int temp = arr[i];
    //                    arr[i] = arr[i + 1];
    //                    arr[i + 1] = temp;
    //                }
    //            }
    //        }
    //    }

    //    static void BubbleSortImproved(int[] arr)
    //    {
    //        int swapped = 1;

    //        for (int pass = arr.Length - 1; pass >= 0 && swapped == 1; pass--)
    //        {
    //            swapped = 0;
    //            for (int i = 0; i < pass; i++)
    //            {
    //                if (arr[i] > arr[i + 1])
    //                {
    //                    int temp = arr[i];
    //                    arr[i] = arr[i + 1];
    //                    arr[i + 1] = temp;
    //                    swapped = 1;
    //                }
    //            }
    //        }
    //    }
    //}

    //// Time complexity: Best case: O(n), worst case and average case: O(n^2)
    #endregion

    #region Selection Sort
    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] arr = { 12, 5, 3, 6, 8, 213, 45, 2, 0, 23 };

    //        SelectionSort(arr);

    //        foreach (int i in arr)
    //        {
    //            Console.Write(i + " ");
    //        }
    //    }

    //    static void SelectionSort(int[] arr)
    //    {
    //        for (int i = 0; i < arr.Length - 1; i++)
    //        {
    //            int minPos = i;

    //            for (int j = i + 1; j < arr.Length; j++)
    //            {
    //                if (arr[j] < arr[minPos])
    //                    minPos = j;
    //            }

    //            int temp = arr[minPos];
    //            arr[minPos] = arr[i];
    //            arr[i] = temp;
    //        }
    //    }
    //}

    //// Time complexity: in all case is O(n^2)
    #endregion

    #region Insertion Sort
    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] arr = { 12, 5, 3, 6, 8, 213, 45, 2, 0, 23 };

    //        InsertionSort(arr);

    //        foreach (int i in arr)
    //        {
    //            Console.Write(i + " ");
    //        }
    //    }

    //    static void InsertionSort(int[] arr)
    //    {
    //        for (int i = 1; i < arr.Length; i++)
    //        {
    //            int v = arr[i];
    //            int j = i;

    //            while (j > 0 && arr[j - 1] > v)
    //            {
    //                arr[j] = arr[j - 1];
    //                j--;
    //            }

    //            arr[j] = v;
    //        }
    //    }
    //}

    //// Time complexity: Worst case/Average case: O(n^2); Best case: O(n) 
    #endregion

    #region Shell Sort
    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] arr = { 12, 5, 3, 5, 5, 6, 8, 213, 45, 2, 0, 23 };

    //        ShellSort(arr);

    //        foreach (int i in arr)
    //        {
    //            Console.Write(i + " ");
    //        }
    //    }

    //    static void ShellSort(int[] arr)
    //    {
    //        int h = 3;

    //        while (h > 0)
    //        {
    //            for (int i = h; i < arr.Length; i++)
    //            {
    //                int temp = arr[i];
    //                int j = i;

    //                while (j >= h && arr[j - h] > temp)
    //                {
    //                    arr[j] = arr[j - h];
    //                    j -= h;
    //                }

    //                arr[j] = temp;
    //            }

    //            h = h / 2;
    //        }

    //        // Another way to execute this code
    //        //while (h <= arr.Length / 9)
    //        //{
    //        //    h = 3 * h + 1;
    //        //}

    //        //while (h > 0)
    //        //{
    //        //    for (int i = h; i < arr.Length; i++)
    //        //    {
    //        //        int v = arr[i];
    //        //        int j = i;

    //        //        while (j >= h && arr[j - h] > v)
    //        //        {
    //        //            arr[j] = arr[j - h];
    //        //            j -= h;
    //        //        }

    //        //        arr[j] = v;
    //        //    }

    //        //    h /= 3;
    //        //}
    //    }
    //}

    //// Best case complexity: O(n)
    //// Average case complexity depends on gap sequence
    //// Worst case complexity depends on gap sequence.Best known: O(nlogn^2)
    #endregion

    #region Merge Sort
    class MainClass
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 5, 6, 18, 1 }; // 12, 5, 3, 6, 8, 213, 45, 2, 0, 23

            MergeSort(arr, 0, arr.Length - 1);

            foreach (int i in arr)
            {
                Console.Write(i + "  ");
            }
        }

        static void MergeSort(int[] arr, int start, int end)
        {
            if (end > start)
            {
                int mid = (end + start) / 2;
                MergeSort(arr, start, mid);
                MergeSort(arr, mid + 1, end);
                Merge(arr, start, mid, end);
            }
        }

        static void Merge(int[] arr, int start, int mid, int end)
        {
            int p = start, q = mid + 1, k = 0;

            int[] A = new int[end - start + 1];

            for (int i = start; i <= end; i++)
            {
                if (p > mid)
                    A[k++] = arr[q++];
                else if (q > end)
                    A[k++] = arr[p++];
                else if (arr[p] < arr[q])
                    A[k++] = arr[p++];
                else
                    A[k++] = arr[q++];
            }

            for (int j = 0; j < k; j++)
            {
                arr[start] = A[j];
                start++;
            }
        }
    }

    //// Time complexity: In 3 cases is O(nlogn)
    #endregion

    #region Quick Sort
    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] arr = { 12, 5, 3, 6, 8, 213, 45, 2, 0, 23, -6 };

    //        QuickSort(arr, 0, arr.Length - 1);

    //        foreach (int i in arr)
    //        {
    //            Console.Write(i + "  ");
    //        }
    //    }

    //    static void QuickSort(int[] arr, int low, int high)
    //    {
    //        if (high > low)
    //        {
    //            int pivot = Partition(arr, low, high);
    //            QuickSort(arr, low, pivot - 1);
    //            QuickSort(arr, pivot + 1, high);
    //        }
    //    }

    //    static int Partition(int[] arr, int low, int high)
    //    {
    //        int left = low, right = high, pivotItem = arr[low];

    //        while (left < right)
    //        {
    //            while (arr[left] <= pivotItem)
    //                left++;
    //            while (arr[right] > pivotItem)
    //                right--;

    //            if (left < right)
    //            {
    //                int temp = arr[left];
    //                arr[left] = arr[right];
    //                arr[right] = temp;
    //            }
    //        }

    //        arr[low] = arr[right];
    //        arr[right] = pivotItem;
    //        return right;
    //    }
    //}

    //// Worst case Complexity: O(n^2)
    //// Best case Complexity: O(nlogn)
    //// Average case Complexity: O(nlogn)
    #endregion

    #region Counting Sort
    //public class Solution
    //{
    //    public void CountingSort(int[] arr, int[] B, int k)
    //    {
    //        int[] temp = new int[k];

    //        for (int i = 0; i < k; i++)
    //        {
    //            temp[i] = 0;
    //        }
    //        /
    //        for (int j = 0; j < arr.Length; j++)
    //        {
    //            temp[arr[j]] += 1;
    //        }

    //        for (int i = 1; i < k; i++)
    //        {
    //            temp[i] += temp[i - 1];
    //        }

    //        for (int j = arr.Length - 1; j >= 0; j--)
    //        {
    //            B[temp[arr[j]] - 1] = arr[j];
    //            temp[arr[j]] -= 1;
    //        }
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();

    //        int[] arr = { 12, 5, 3, 6, 8, 213, 45, 2, 0, 23 };
    //        int[] B = new int[arr.Length];

    //        solution.CountingSort(arr, B, arr.Max() + 1);

    //        foreach (int i in B)
    //        {
    //            Console.Write(i + " ");
    //        }
    //    }
    //}

    //// Time complexity: O(n)
    #endregion

    #region Bucket Sort
    //public class Solution
    //{
    //    public void BucketSort(int[] arr)
    //    {
    //        int[] buckets = new int[arr.Max() + 1];

    //        for (int j = 0; j < buckets.Length; j++)
    //            buckets[j] = 0;

    //        for (int i = 0; i < arr.Length; i++)
    //            buckets[arr[i]]++;

    //        for (int i = 0, j = 0; j < buckets.Length; j++)
    //        {
    //            for (int k = buckets[j]; k > 0; k--)
    //            {
    //                arr[i] = j;
    //                i++;
    //            }
    //        }
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();

    //        int[] arr = { 12, 5, 3, 6, 8 };

    //        solution.BucketSort(arr);

    //        foreach (int i in arr)
    //        {
    //            Console.Write(i + " ");
    //        }
    //    }
    //}

    //// Time complexity: O(n)
    #endregion

    #region Radix Sort
    //public class Solution
    //{
    //    public void RadixSort(int[] arr)
    //    {
    //        int maxVal = arr.Max();
    //        int exp = 1; // Initialize the exponent for the current digit place

    //        while (maxVal / exp > 0)
    //        {
    //            int[] output = new int[arr.Length];
    //            CountingSort(arr, output, maxVal + 1);
    //            Array.Copy(output, arr, arr.Length);

    //            exp *= 10;
    //        }
    //    }

    //    private void CountingSort(int[] arr, int[] B, int k)
    //    {
    //        int[] temp = new int[k];

    //        for (int i = 0; i < k; i++)
    //        {
    //            temp[i] = 0;
    //        }

    //        for (int j = 0; j < arr.Length; j++)
    //        {
    //            temp[arr[j]] = temp[arr[j]] + 1;
    //        }

    //        for (int i = 1; i < k; i++)
    //        {
    //            temp[i] = temp[i] + temp[i - 1];
    //        }

    //        for (int j = arr.Length - 1; j >= 0; j--)
    //        {
    //            B[temp[arr[j]] - 1] = arr[j];
    //            temp[arr[j]] = temp[arr[j]] - 1;
    //        }
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();

    //        int[] arr = { 12, 5, 3, 6, 8, 213, 45, 2, 0, 23 };

    //        solution.RadixSort(arr);

    //        foreach (int i in arr)
    //        {
    //            Console.Write(i + " ");
    //        }
    //    }
    //}

    //// Time complexity: O(n)
    #endregion


}