namespace DSA
{
    #region Problem 1
    /*
	 * - Problem: Given an array F with size n. Assume the array content F[i] indicates the length of the ith 
	 *            file and we want to merge all these files into one single file. Check whether the following 
	 *            algorithm gives the best solution for this problem or not?
	 * - Algorithm: Merge the files contiguously (liền kề nhau). That means select the first two files and merge
	 *				them. Then select the output of the previous merge and merge with the third file, and keep 
	 *				going...
	 * - NOTE: Given two files A and B with sizes m and n, the complexity of merging is O(m + n).
	 */

    /*
	 * - Solution: This algorithm will not produce the optimal solution
	 *		+ Assume we have input: F = {10,5,100,50,20,15} 
	 *		+ The total cost of merging = Cost of all merging operations = 15 + 115 + 165 + 185 + 200 = 680.
	 *		+ If we sort the input after merge: F = {5,10,15,20,50,100}
	 *		+ the total cost of merging = 15 + 30 + 50 + 100 + 200 = 395 
	 */
    #endregion

    #region Problem 2
    /*
	 * - Problem: Similar to Problem-1, does the following algorithm give the optimal solution?
	 * - Algorithm: Merge the files in pairs. That means after the first step, the algorithm produces the n/2 
	 *				intermediate files. For the next step, we need to consider these intermediate files and 
	 *				merge them in pairs and keep going.
	 * - NOTE: Sometimes this algorithm is called 2-way merging. Instead of two files at a time, if we merge 
	 *		   K files at a time then we call it K-way merging.
	 */

    /*
	 * - Solution: This algorithm will not produce the optimal solution
	 *		+ Assume we have input: F = {10,5,100,50,20,15} 
	 *		+ we need to merge the first pair of files (10 and 5 size files), the second pair of files (100 and 50) 
	 *		  and the third pair of files (20 and 15). We have result {15, 150, 35}
	 *		+ Iteratve this process: {165, 35}, {185}.
	 *		+ The total cost of merging = Cost of all merging operations = 15 + 150 + 35 + 165 + 185 = 550 > 395 
	 *		(in previous case)
	 */
    #endregion

    #region Problem 3
    /*
	 * - Problem: In Problem-1, what is the best way to merge all the files into a single files?
	 */

    /*
	 * - Algorithm: 1. Store file sizes in a priority queue. The key of elements are file lengths.
	 *				2. Repeat the following until there is only one file:
	 *					a. Extract two smallest elements X and Y
	 *					b. Merge X and Y and insert this new file in the priority queue
	 * - Variant of same algorithm: 1. Sort the file sizes in ascending order.
	 *								2. Repeat the following until there is only one file:
	 *									a. Take the first two elements (smallest) X and Y.
	 *									b. Merge X and Y and insert this new file in the sorted list.
	 */

    //public class Solution
    //{
    //	public int MergeFiles(int[] F)
    //	{
    //           var priorityQueue = new SortedSet<(int, int)>();
    //           for (int i = 0; i < F.Length; i++)
    //           {
    //               priorityQueue.Add((F[i], i));
    //           }

    //           int totalCost = 0;

    //           // Repeat until there is only one file
    //           while (priorityQueue.Count > 1)
    //           {
    //               // Extract two smallest elements X and Y
    //               var smallest = priorityQueue.Min;
    //               priorityQueue.Remove(smallest);
    //               var secondSmallest = priorityQueue.Min;
    //               priorityQueue.Remove(secondSmallest);

    //               // Merge X and Y and insert this new file in the priority queue
    //               int mergedSize = smallest.Item1 + secondSmallest.Item1;
    //               totalCost += mergedSize;
    //               priorityQueue.Add((mergedSize, smallest.Item2));
    //           }

    //           return totalCost;
    //       }
    //}

    //class MainClass
    //{
    //	static void Main(string[] args)
    //	{
    //		Solution solution = new Solution();
    //		int[] F = { 10, 5, 100, 50, 20, 15 };

    //		Console.WriteLine(solution.MergeFiles(F));
    //	}
    //}
    #endregion

    #region Problem 4. Interval Scheduling Algorithm
    /*
     * - Problem: Given a set of n intervals S = {(start.i, end.j)|1 ≤ i ≤ n}. Let us assume that we want to find 
     *            a maximum subset S′ of S such that no pair of intervals in S′ overlaps. Check whether the following
     *            algorithm works or not.
     */

    /*
     * - Algorithm:
     *          While (S is not empty){
     *              Select the interval I that overlaps the least number of other intervals 
     *              Add I to final solution set S'.
     *              Remove all intervals from S that overlap with I
     *          }
     */

    /*
     * - Solution: This algorithm does not solve the problem of finding a maximum subset of non-overlapping intervals. 
     * - Explain:       _____            ______
     *                  _____            ______
     *                  _____   ___c__   ______
     *              ___m__  ___o__   ___n__   ___k__
     *      + Result will be 'C' because the interval that overlaps with the fewest others is C
     *      + Answer expect: {M, O, N, K}
     */
    #endregion

    #region Problem 5
    /*
     * - Problem: In Problem-4, if we select the interval that starts earliest (also not overlapping with already chosen 
     *            intervals), does it give the optimal solution?
     */

    // - Solution: Absolutely not.
    #endregion

    #region Problem 6
    /*
     * - Problem: In Problem-4, if we select the shortest interval (but it is not overlapping the already chosen intervals),
     *            does it give the optimal solution?
     */

    // - Solution: This also will not give the optimal solution
    #endregion

    #region Problem 7. With above problem, what is the optimal solution?
    /*
     * - Algorithm: 
     *      Sort intervals according to the right-most ends [end times];
     *      for every consecutive(liên tiếp) interval{
     *          - If the left-most end is after the right-most end of the last selected interval then we select this interval
     *          - Other wise we skip it and go to the next interval
     *      }
     */

    public class Interval
    {
        public string Name { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            List<Interval> intervals = new List<Interval>
        {
            new Interval { Name = "A", Start = 7, End = 9 },
            new Interval { Name = "B", Start = 6, End = 8 },
            new Interval { Name = "C", Start = 6, End = 7 },
            new Interval { Name = "D", Start = 4, End = 5 },
            new Interval { Name = "E", Start = 3, End = 4 }
        };

            // Sort intervals according to the right-most ends [end times]
            intervals.Sort((a, b) => a.End.CompareTo(b.End));

            List<Interval> result = new List<Interval>();
            int lastEnd = int.MinValue;

            // For every consecutive interval
            foreach (var interval in intervals)
            {
                // If the left-most end is after the right-most end of the last selected interval then we select this interval
                if (interval.Start >= lastEnd)
                {
                    result.Add(interval);
                    lastEnd = interval.End;
                }
                // Otherwise we skip it and go to the next interval
            }

            // Print the selected intervals
            foreach (var interval in result)
            {
                Console.WriteLine($"{interval.Name}: [{interval.Start}, {interval.End}]");
            }
        }
    }
    #endregion
}