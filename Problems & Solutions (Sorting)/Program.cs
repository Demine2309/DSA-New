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
    public class Solution
    {
        // First Way
        public void WhoWinTheElection(int[] arr)
        {
            Dictionary<int, int> ID = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                ID.Add(i + 1, arr[i]);
            }

            BucketSort(arr);

            Console.WriteLine(GetKeyFromValue(ID, arr[arr.Length - 1]));
        }

        public void BucketSort(int[] arr)
        {
            int[] buckets = new int[arr.Max() + 1];

            for (int j = 0; j < buckets.Length; j++)
                buckets[j] = 0;

            for (int i = 0; i < arr.Length; i++)
                buckets[arr[i]]++;

            for (int i = 0, j = 0; j < buckets.Length; j++)
            {
                for (int k = buckets[j]; k > 0; k--)
                {
                    arr[i] = j;
                    i++;
                }
            }
        }

        private TKey GetKeyFromValue<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TValue value)
        {
            foreach (KeyValuePair<TKey, TValue> pair in dictionary)
            {
                if (pair.Value.Equals(value))
                    return pair.Key;
            }

            throw new Exception("Value not found in dictionary");
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] arr = { 34, 54, 12, 4, 23, 65, 2, 87, 2, 6, 9, 24 };

            solution.WhoWinTheElection(arr);
        }
    }
    #endregion

    #region Problem 6. Given an array A of n elements, each of which is an integer in the range [1, n^2], how do we sort the array in O(n) time?

    #endregion
}