namespace DSA
{
    #region Problem 1. Given an array of n numbers, give an algorithm for checking whether there are any duplicate elements in the array or no?
    //public class Solution
    //{
    //    public bool IsDuplicated(int[] arr)
    //    {
    //        Array.Sort(arr);

    //        for(int i = 0; i < arr.Length - 1; i++)
    //        {
    //            if (arr[i] == arr[i + 1])
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

    //        int[] arr = { 12, 5, 48, 5, 4, 13, 5, 4, 56, 1, 2, 84, 5, 1, 2, 4, 51, 5, 4, 5, 1, 54, 8, 48, 51 };

    //        Console.WriteLine(solution.IsDuplicated(arr));
    //    }
    //}
    #endregion

    #region Problem 5. Given an array of n numbers. Give an algorithm for finding the element which appears the maximum number of times in the array?
    //public class Solution
    //{
    //    public int FindingElementAppearsMaximumTimes(int[] arr)
    //    {
    //        Array.Sort(arr);
    //        Dictionary<int, int> results = new Dictionary<int, int>();

    //        int k = 1;

    //        for(int i = 0; i < arr.Length - 1; i++)
    //        {
    //            if (arr[i] == arr[i + 1])
    //                k++;
    //            else if (arr[i] != arr[i + 1])
    //            {
    //                results.Add(arr[i], k);
    //                k = 1;
    //            }
    //        }

    //        int maxValue = results[arr[0]];

    //        foreach (int i in results.Values)
    //        {
    //            if(maxValue < i)
    //                maxValue = i;
    //        }

    //        return GetKeyFromValue(results, maxValue);
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

    //        int[] arr = { 12, 5, 48, 5, 4, 13, 5, 4, 56, 1, 2, 84, 5, 1, 2, 4, 51, 5, 4, 5, 1, 54, 8, 48, 51 };

    //        Array.Sort(arr);

    //        foreach(int i in arr)
    //            Console.Write(i + "  ");

    //        Console.WriteLine("\n" + solution.FindingElementAppearsMaximumTimes(arr));
    //    }
    //}
    #endregion

    #region Problem 9
    /* 
     * - Problem: Given an array of n numbers, give an algorithm for finding the first element in the array which
     *            is repeated. For example, in the array A = {3,2,1,2,2,3}, the first repeated number is 3 (not 2). That means, 
     *            we need to return the first element among the repeated elements.
     */
    //public class Solution
    //{
    //    public int FindingTheFirstElementRepeated(int[] arr)
    //    {
    //        for (int i = 0; i < arr.Length - 1; i++)
    //        {
    //            for (int j = i + 1; j < arr.Length; j++)
    //            {
    //                if (arr[i] == arr[j])
    //                    return arr[i];
    //            }
    //        }

    //        return -1;
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();
    //        int[] arr = { 3, 2, 1, 2, 2, 3 };

    //        Console.WriteLine(solution.FindingTheFirstElementRepeated(arr));
    //    }
    //}
    #endregion

    #region Problem 13. Finding the Missing number
    /*
     * - Problem: We are given a list of n – 1 integers and these integers are in the range of 1 to n. There are no 
     *            duplicates in the list. One of the integers is missing in the list. Given an algorithm to find the
     *            missing integer. Example: I/P: [1,2,4,6,3,7,8] O/P: 5
     */
    public class Solution
    {
        public int FindingMissingNumber(int[] arr)
        {
            Array.Sort(arr);

            for(int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i + 1] - arr[i] == 2)
                {
                    return (arr[i] + 1);
                }
            }

            return -1;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] arr = { 1, 2, 4, 6, 3, 7, 8 };

            Console.WriteLine(solution.FindingMissingNumber(arr));
        }
    }
    #endregion
}