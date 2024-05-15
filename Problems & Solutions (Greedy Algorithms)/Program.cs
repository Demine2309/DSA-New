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
    public class Solution
    {

    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();


        }
    }
    #endregion
}