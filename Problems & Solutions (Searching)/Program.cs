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
    public class Solution
    {
        public int FindingElementAppearsMaximumTimes(int[] arr)
        {
            Array.Sort(arr);
            Dictionary<int, int> results = new Dictionary<int, int>();

            
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

            int[] arr = { 12, 5, 48, 5, 4, 13, 5, 4, 56, 1, 2, 84, 5, 1, 2, 4, 51, 5, 4, 5, 1, 54, 8, 48, 51 };


        }
    }
    #endregion
}