namespace DSA
{
    #region Problem 5. Given an array, give an algorithm for finding the maximum and minimum
    public class Solution
    {
        public void FindingMaxAndMin(int[] arr, int low, int high, out int min, out int max)
        {
            if(low == high)
            {
                min = max = arr[low];
                return;
            }

            if(high == low + 1)
            {
                if (arr[low] < arr[high])
                {
                    min = arr[low];
                    max = arr[high];
                }
                else
                {
                    min = arr[high];
                    max = arr[low];
                }

                return;
            }

            int mid = (low + high) / 2;
            FindingMaxAndMin(arr, low, mid, out int min1, out int max1);
            FindingMaxAndMin(arr, mid + 1, high, out int min2, out int max2);

            min = Math.Min(min1, min2);
            max = Math.Max(max1, max2);
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] arr = { 2, 15, 3, 5, 1, 23, 4, 16, 7, 0, 12 };

            solution.FindingMaxAndMin(arr, 0, arr.Length, out int min, out int max);
        }
    }
    #endregion
}