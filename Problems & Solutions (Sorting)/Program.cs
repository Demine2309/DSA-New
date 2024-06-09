using System;

namespace DSA
{
    #region Problem 1
    /* - Problem: Given an array A[0...n– 1] of n numbers containing the repetition of some number.
     *   Give an algorithm for checking whether there are repeated elements or not. Assume that we 
     *   are not allowed to use additional space (i.e., we can use a few temporary variables, O(1) 
     *   storage).
	 */
    //public class Solution
    //{
    //    public bool IsRepeated(int[] arr)
    //    {
    //        for (int i = 0; i < arr.Length - 1; i++)
    //        {
    //            for (int j = i + 1; j < arr.Length; j++)
    //            {
    //                if (arr[i] == arr[j])
    //                    return true;
    //            }
    //        }

    //        return false;
    //    }


    //    // Using heapsort to improve above code
    //    private void Heapify(int[] arr, int n, int i)
    //    {
    //        int largest = i;
    //        int left = 2 * i + 1;
    //        int right = 2 * i + 2;

    //        if (left < n && arr[left] > arr[largest])
    //            largest = left;

    //        if (right < n && arr[right] > arr[largest])
    //            largest = right;

    //        if (largest != i)
    //        {
    //            int swap = arr[i];
    //            arr[i] = arr[largest];
    //            arr[largest] = swap;

    //            Heapify(arr, n, largest);
    //        }
    //    }

    //    private void HeapSort(int[] arr)
    //    {
    //        for (int i = arr.Length / 2 - 1; i >= 0; i--)
    //            Heapify(arr, arr.Length, i);

    //        for (int i = arr.Length - 1; i >= 0; i--)
    //        {
    //            int temp = arr[0];
    //            arr[0] = arr[i];
    //            arr[i] = temp;

    //            Heapify(arr, i, 0);
    //        }
    //    }

    //    public bool IsRepeatedImporve(int[] arr)
    //    {
    //        HeapSort(arr);

    //        for (int i = 1; i < arr.Length; i++)
    //        {
    //            if (arr[i] == arr[i - 1])
    //                return true;
    //        }

    //        return false;
    //    }

    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();
    //        int[] arr = { 5, 4, 8, 9, 7, 1, 3, 0 };

    //        //bool isRepeated = solution.IsRepeated(arr);
    //        bool isRepeated = solution.IsRepeatedImporve(arr);

    //        if (isRepeated == true)
    //            Console.WriteLine("There are repeated elements!");
    //        else
    //            Console.WriteLine("There aren't repeated elements!");
    //    }
    //}
    #endregion

    #region Problem 3
    /*
     * - Problem: Given an array A[0 ...n – 1], where each element of the array represents a vote in the election. 
     *   Assume that each vote is given as an integer representing the ID of the chosen candidate. Give an algorithm 
     *   for determining who wins the election.
     */
    //public class Solution
    //{
    //    // First Way
    //    public void WhoWinTheElection(int[] arr)
    //    {
    //        Dictionary<int, int> ID = new Dictionary<int, int>();

    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            ID.Add(i + 1, arr[i]);
    //        }

    //        BucketSort(arr);

    //        Console.WriteLine(GetKeyFromValue(ID, arr[arr.Length - 1]));
    //    }

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

    //    private TKey GetKeyFromValue<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TValue value)
    //    {
    //        foreach (KeyValuePair<TKey, TValue> pair in dictionary)
    //        {
    //            if (pair.Value.Equals(value))
    //                return pair.Key;
    //        }

    //        throw new Exception("Value not found in dictionary");
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();
    //        int[] arr = { 34, 54, 12, 4, 23, 65, 2, 87, 2, 6, 9, 24 };

    //        solution.WhoWinTheElection(arr);
    //    }
    //}
    #endregion

    #region Problem 6. Given an array A of n elements, each of which is an integer in the range [1, n^2], how do we sort the array in O(n) time?
    /*
     * * Solution: Using radix sort
     *             If we subtract each number by 1 then we get the range [0, n^2 – 1]. If we consider all numbers as 2 –digit base n.Each digit 
     *             ranges from 0 to n^2 – 1. Sort this using radix sort.This uses only two calls to counting sort.Finally, add 1 to all the numbers. 
     *             Since there are 2 calls, the complexity is O(2n) ≈ O(n).
    */

    //public class Solution
    //{
    //    public void SortingArray(int[] arr)
    //    {
    //        int n = arr.Length;
    //        Dictionary<float, int> myTable = new Dictionary<float, int>();

    //        for(int i = 0; i < arr.Length; i++)
    //        {
    //            myTable.Add(arr[i], n ^ 2 / arr[i]);
    //        }

    //        for()
    //    }    

    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();


    //    }
    //}
    #endregion

    #region Problem 7. For Problem-6, what if the range is [1...n^3]?
    //public class Solution
    //{
    //    public void SortingArray(int[] arr)
    //    {
    //        int n = arr.Length;
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();


    //    }
    //}
    #endregion

    #region Problem 8. Given an array with n integers, each of value less than n^100, can it be sorted in linear time?
    // Solution: Yes
    #endregion

    #region Problem 9
    /* 
     * - Problem: Let A and B be two arrays of n elements each. Given a numbe K, give an O(nlogn) time algorithm for determining
     *            whether there exists a ∈ A and b ∈ B such that a + b = K.
    */

    //public class Solution
    //{
    //    public bool IsExisting(int[] A, int[] B, int k)
    //    {
    //        Array.Sort(B);

    //        foreach(int a in A)
    //        {
    //            int complement = k - a;

    //            if(Array.BinarySearch(B, complement) >= 0)
    //                return true;
    //        }

    //        return false;
    //    }

    //    //private void MergeSort(int[] arr, int start, int end)
    //    //{
    //    //    if (end > start)
    //    //    {
    //    //        int mid = (end + start) / 2;
    //    //        MergeSort(arr, start, mid);
    //    //        MergeSort(arr, mid + 1, end);
    //    //        Merge(arr, start, mid, end);
    //    //    }
    //    //}

    //    //private void Merge(int[] arr, int start, int mid, int end)
    //    //{
    //    //    int p = start, q = mid + 1, k = 0;

    //    //    int[] A = new int[end - start + 1];

    //    //    for (int i = start; i <= end; i++)
    //    //    {
    //    //        if (p > mid)
    //    //            A[k++] = arr[q++];
    //    //        else if (q > end)
    //    //            A[k++] = arr[p++];
    //    //        else if (arr[p] < arr[q])
    //    //            A[k++] = arr[p++];
    //    //        else
    //    //            A[k++] = arr[q++];
    //    //    }

    //    //    for (int j = 0; j < k; j++)
    //    //    {
    //    //        arr[start] = A[j];
    //    //        start++;
    //    //    }
    //    //}
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();

    //        int[] A = { 3, 5, 1, 4, 6, 2 };
    //        int[] B = { 6, 3, 7, 2, 1, 8, 0 };
    //        int k = 15;

    //        Console.WriteLine(solution.IsExisting(A, B, k));
    //    }
    //}
    #endregion

    #region Problem 10
    /*
     * Problem: Let A,B and C be three arrays of n elements each. Given a number K, give an O(nlogn) time algorithm for 
     *          determining whether there exists a ∈ A, b ∈ B and c ∈ C such that a + b + c = K.
     */
    //public class Solution
    //{
    //    public bool IsExisting(int[] A, int[] B, int[] C, int k)
    //    {
    //        Array.Sort(A);
    //        Array.Sort(B);

    //        foreach(int c in C)
    //        {
    //            int target = k - c;
    //            int left = 0;
    //            int right = A.Length - 1;

    //            while (left < A.Length && right >= 0)
    //            {
    //                int sum = A[left] + B[right];

    //                if (sum == target)
    //                    return true;
    //                else if (sum < target)
    //                    left++;
    //                else
    //                    right--;
    //            }
    //        }

    //        return false;
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();

    //        int[] A = { 23, 4, 1, 4, 1, 3, 5, 2, 5, 7 };
    //        int[] B = { 32, 4, 1, 8, 3, 34, 12, 3, 8, 6 };
    //        int[] C = { 39, 16, 7, 2, 1, 2, 3, 13, 3, 9 };

    //        int k = 39;

    //        Console.WriteLine(solution.IsExisting(A, B, C, k));
    //    }
    //}
    #endregion

    #region Problem 16
    /*
     * Problem: Sort an array of 0’s, 1’s and 2’s: Given an array A[] consisting of 0’s, 1’s and 2’s, give an algorithm 
     *          for sorting A[]. The algorithm should put all 0’s first, then all 1’s and all 2’s last.
     *          Example: Input = {0,1,1,0,1,2,1,2,0,0,0,1}, Output = {0,0,0,0,0,1,1,1,1,1,2,2}
     */
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

    //        int[] arr = { 0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1 };

    //        solution.BucketSort(arr);

    //        foreach(int i in arr)
    //        {
    //            Console.Write(i + "  ");
    //        }
    //    }
    //}
    #endregion

    #region Problem 18. How do we find the number that appeared the maximum number of times in an array?
    //public class Solution
    //{
    //    public int NumberAppearMaxTimes(int[] arr)
    //    {
    //        int[] buckets = new int[arr.Max() + 1];
    //        int maxPos = 0;

    //        for (int i = 0; i < buckets.Length; i++)
    //            buckets[i] = 0;

    //        for (int i = 0; i < arr.Length; i++)
    //            buckets[arr[i]]++;

    //        for (int i = 0; i < buckets.Length; i++)
    //        {
    //                if (buckets[maxPos] < buckets[i])
    //                    maxPos = i;           
    //        }

    //        return maxPos;
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();

    //        int[] arr = { 12, 145, 46, 12, 5, 8, 4, 3, 5, 6, 6, 14, 7, 8, 8, 9, 7, 5, 4, 1, 2, 6, 48, 75, 2, 1, 3, 6, 12, 4, 5, 87, 6 };

    //        Console.WriteLine(solution.NumberAppearMaxTimes(arr));
    //    }
    //}
    #endregion

    #region Problem 21. Given a 2GB file with one string per line, which sorting algorithm would we use to sort the file and why?
    /*
     * - Solution: 
     * 
     */
    #endregion
}